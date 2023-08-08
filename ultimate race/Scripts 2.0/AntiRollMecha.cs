using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiRollMecha : MonoBehaviour
{
    [SerializeField] private WheelCollider wheelL;

    [SerializeField] private WheelCollider wheelR;

    [SerializeField] private float rollForce;

    [SerializeField] private Rigidbody car;
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        WheelHit hit;
        float travelL=1.0f;
        float travelR=1.0f;

        bool grounddL = wheelL.GetGroundHit(out hit);
        if (grounddL)
        {
            travelL = (-wheelL.transform.InverseTransformPoint(hit.point).y - wheelL.radius) / wheelL.suspensionDistance;
        }

        bool groundR = wheelR.GetGroundHit(out hit);

        if (groundR)
        {
            travelR = (-wheelR.transform.InverseTransformPoint(hit.point).y - wheelR.radius) / wheelR.suspensionDistance;
        }

        float antiRoll = (travelL - travelR) * rollForce;

        if (grounddL)
        {
            car.AddForceAtPosition(-wheelL.transform.up * antiRoll, wheelL.transform.position);
        }
        
        if (groundR)
        {
            car.AddForceAtPosition(wheelR.transform.up * antiRoll, wheelR.transform.position);
        }


    }
}
