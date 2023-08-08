using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class MoneyIncrement : MonoBehaviour
{
    public Money money;

    [SerializeField] private int rate;
    // Start is called before the first frame update
    void Update()
    {
       
        if (Application.isPlaying)
        {
            money.LoadMode();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            money.IncreaseMoney(rate);
        }
        
        money.SaveMode();
    }
}
