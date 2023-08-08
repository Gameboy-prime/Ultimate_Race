using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateVehicle : MonoBehaviour
{
    
    private int carFigure;
    
    [SerializeField] private GameObject car1;
    [SerializeField] private GameObject car2;
    [SerializeField] private GameObject car3;

    [SerializeField] private Transform spawnPoint;
    // Start is called before the first 
    void Awake()
    {
        //Set the value of the static variable carType to determine which vehicle is Spawned
        SpawnVehicle();
        
    }

    public void SpawnVehicle()
    {
        carFigure = VehicleSelect.CarType;
        if (carFigure == 1)
        {
            Instantiate(car1, spawnPoint.position, Quaternion.identity);
        }

        if (carFigure == 2)
        {
            Instantiate(car2, spawnPoint.position, Quaternion.identity);
        }

        if(carFigure==3)
        {
            Instantiate(car3, spawnPoint.position, Quaternion.identity);
        }
    }
}
