using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;

public class GunController : MonoBehaviour
{
   private bool enableShooting;
   //Gun stats
   [SerializeField] private float damage;
   [SerializeField] private float timeBetweenShooting, timeBetweenShot, range, spread, reloadTime;
   [SerializeField] private int magazineSize, clipSize, bulletPerTap,bulletLeft;
   [SerializeField] private bool allowButtonHold;
   
   [SerializeField] private int bulletShot;
   //BOols
   private bool readyToShoot, reloading, shooting;
   
   //References
   [SerializeField] private Camera carCamera;
   [SerializeField] private Transform attackPoint;
   [SerializeField] private RaycastHit rayHit;
   [SerializeField] private LayerMask whatIsEnemy;

   [SerializeField] private RaycastHit ray;
   
   
   
   //CAmera Shake ANd Effect References
   //public CameraShake camShake;
   public GunBar gunBar;
   public StressReceiver stressreceiver;
   
   
   [SerializeField] private GameObject muzzleFlash, bulletHole;
   [SerializeField] private float shakeMag, shakeDuration;
   [SerializeField] private float impactForce;
   [SerializeField] private float stress;

   [SerializeField] private AudioSource gunShot;

   //[SerializeField] private GameObject trail;
   
   //RigidBody
   //[SerializeField] private Rigidbody bullet;

   //[SerializeField] private float forcePower;

   [SerializeField] private TextMeshProUGUI magazineBox;


   private void Start()
   {
      Cursor.lockState= CursorLockMode.Locked;
      gunBar.SetMaxBullet(clipSize);
   }


   private void Awake()
   {
      bulletLeft = clipSize;
      readyToShoot = true;
      
      
   }


   private void Update()
   {
      //Input For the Gun
      MyInput();
      
      //TO Set the the bullets left in the Gun Bar
      gunBar.SetBullet(bulletLeft);
      
      magazineBox.GetComponent<TextMeshProUGUI>().text = "" + magazineSize.ToString("f0") + '/' + bulletLeft.ToString("f0");
      
      
      //To make a trail to know where to aim
      Physics.Raycast(transform.position, transform.forward, out ray, Mathf.Infinity, whatIsEnemy);
      //trail.transform.position= ray.point;
      
   }

   private void MyInput()
   {
      if(allowButtonHold)shooting = Input.GetKey(KeyCode.Mouse0);
      else shooting = Input.GetKeyDown(KeyCode.Mouse0);

      if (Input.GetKeyDown(KeyCode.R) && !reloading && bulletLeft < clipSize)
      {
         Reload();
      }

      if (shooting && readyToShoot && !reloading && bulletLeft > 0)
      {
         bulletPerTap = bulletShot;
         Shoot();
      }
   }

   private void Shoot()
   {
      readyToShoot = false;
      gunShot.Play();
      //spread
      
      
      //float x = Random.Range(-spread, spread);
      //Vector3 direction = carCamera.transform.position + new Vector3(x,x,0);
      
      
      //RayCast
      
      if (Physics.Raycast(transform.position, transform.forward, out rayHit, range, whatIsEnemy))
      {
         Debug.Log(rayHit.collider.name);
         if (rayHit.collider.CompareTag("Enemy"))
         {
            //GetComponent<Rigidbody>().AddForce(Vector3.back, ForceMode.Impulse);
            //FindObjectOfType<ShootingAi>().TakeDamage(damage);
            
            rayHit.collider.GetComponent<ShootingAi>().TakeDamage(damage);
         }

         if (rayHit.rigidbody != null)
         {
            rayHit.rigidbody.AddForce(-rayHit.normal* impactForce);
         }
      }
      
      //RigidBullet();

      bulletLeft -= 1;
      bulletShot -= 1;
      
      
      //Gun UI
      
      
      

      GameObject flash= Instantiate(muzzleFlash, attackPoint.position, Quaternion.Euler(0, 180, 0));
      GameObject hole = Instantiate(bulletHole, rayHit.point, Quaternion.identity);
      Destroy(flash,.2f);
      Destroy(hole, 1f);
      stressreceiver.InduceStress(stress);
      //StartCoroutine(camShake.Shake(shakeDuration, shakeMag));
      
      Invoke("ShootReset", timeBetweenShooting);
   }

   private void ShootReset()
   {
      readyToShoot = true;
   }

   private void Reload()
   {
      reloading = true;
      Invoke("ReloadFinish", reloadTime);
   }

   private void ReloadFinish()
   {
      bulletLeft=clipSize;
      bulletShot = clipSize;
      magazineSize -= clipSize;
      reloading = false;
   }

  /*private void RigidBullet()
   {
      Rigidbody bulletInstance;

      bulletInstance = Instantiate(bullet, attackPoint.position, Quaternion.identity);
      bulletInstance.AddForce(attackPoint.forward*forcePower);
   }*/


  
}
