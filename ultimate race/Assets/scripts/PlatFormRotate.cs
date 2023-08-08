using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormRotate : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;

    [SerializeField] private float rotSpeed;
    
    void Update()
    {
        // Make The Base to start rotation 
        transform.Rotate(Vector3.up*rotSpeed*Time.deltaTime,Space.World);
        Quaternion rot = transform.rotation;
        
        
        // Then set the rotation of the base in sync with the cars
        car1.transform.rotation = rot;
        car2.transform.rotation = rot;
        car3.transform.rotation = rot;
        car4.transform.rotation = rot;
    }
}
