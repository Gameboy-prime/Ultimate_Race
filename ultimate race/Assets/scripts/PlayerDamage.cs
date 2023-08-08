using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private float MaxHealth;
    private float currentHealth;

    [SerializeField] private GameObject explosion;

    public HealthBar healthbar;
    // Start is called before the first frame update
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
            
           
            GameObject explode=Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(explode, 3f);
            Die();
            
            
        }
    }

    private void Die()
    {
        Destroy(gameObject);

    }
    
}
/*

 */
