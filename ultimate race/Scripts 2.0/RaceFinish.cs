using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFinish : MonoBehaviour
{

    [SerializeField] private GameObject car;
    [SerializeField] private GameObject lapTimer;
    [SerializeField] private GameObject camRot;
    [SerializeField] private GameObject mainVisuals;
    
    public LapCount lapCount;

    public CarController control;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            this.GetComponent<BoxCollider>().enabled = false;
            StartCoroutine(DeactivateCar());
            control.ApplyBraking();

        }
        
    }


    IEnumerator DeactivateCar()
    {
        yield return new WaitForSeconds(1);

        car.GetComponent<CarController>().enabled = false;
        lapTimer.GetComponent<LapTimeManagement>().enabled = false;
        
        camRot.SetActive(true);
        mainVisuals.SetActive(false);

        yield return new WaitForSeconds(1);
        
        


    }
}
