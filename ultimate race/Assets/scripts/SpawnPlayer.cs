using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField] private GameObject car;

    [SerializeField] private GameObject spawnCar;
    
    [SerializeField] private GameObject spawnLocation;

    [SerializeField] private GameObject spawnEffect;

    [SerializeField] private Transform initialPos;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(car, initialPos.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        GameObject effect= Instantiate(spawnEffect, spawnLocation.transform.position, Quaternion.identity);
        Destroy(effect,0.1f);
        Destroy(car);
        Instantiate(spawnCar, spawnLocation.transform.position, Quaternion.identity);
       
    }
    
    
}
