using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   

public class CameraFollow : MonoBehaviour
{
    
    [SerializeField] private GameObject car;
    [SerializeField] private float  carX;
    [SerializeField] private float  carY;

    [SerializeField] private float  carZ;
    
    void Update()
    {
        carX= car.transform.eulerAngles.x;
        carY= car.transform.eulerAngles.y;
        carZ= car.transform.eulerAngles.z;
        transform.eulerAngles=new Vector3(carX-carX, carY, carZ-carZ);
        

        
        
    }
}
