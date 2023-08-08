using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAi : MonoBehaviour
{
    [SerializeField] private GameObject particles;
    [SerializeField] private float MaxHealth;
    private float currentHealth;

    [SerializeField] private GameObject explosion;
    
    
    //References

    public HealthBar healthbar;
    void Start()
    {
        currentHealth = MaxHealth;
        healthbar.SetMaxHealth(currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.SetHealth(currentHealth);
    }

    public void TakeDamage(float amount)
    {
        
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            GameObject remenant = Instantiate(particles, gameObject.transform.position, Quaternion.identity);
            
            
            Destroy(remenant, 3f);
            GameObject explode=Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(explode, 1f);
            Die();
            //Instantiate(particles, gameObject.transform.position, Quaternion.identity);
            
            
            FindObjectOfType<ScoreManager>().SetScore();
            
            
        }
    }

    private void Die()
    {
        

        Destroy(gameObject);
        
        


    }
}
