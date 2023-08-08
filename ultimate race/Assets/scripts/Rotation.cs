using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float rotSpeed;

    private float horizontal;

    private float vertical;
    
    //References
    //public Joystick aimStick;
   
    void Update()
    {




        //horizontal = Input.GetAxis("Horizontal Joystick");
        //vertical = Input.GetAxis("Vertical Joystick");
        //Aim();
        


        horizontal = Input.GetAxis("Mouse X");
        vertical = Input.GetAxis("Mouse Y");
        if (transform.rotation.x>-35 && transform.rotation.x< 20)
        {
            transform.Rotate((horizontal*rotSpeed*Vector3.up)*Time.deltaTime, Space.World);
            transform.Rotate(vertical* rotSpeed*Vector3.left*Time.deltaTime, Space.Self);
        }

    }

    /*private void Aim()
    {
        transform.Rotate((aimStick.Horizontal*rotSpeed*Vector3.up)*Time.deltaTime, Space.World);
        transform.Rotate(aimStick.Vertical* rotSpeed*Vector3.left*Time.deltaTime, Space.Self);
        
        
        
    }*/
}
