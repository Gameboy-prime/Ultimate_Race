using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarController : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    
    
    //Input Stats
    private float horizontalInput;
    private float vertiaclInput;
    private bool isBreaking;
    
    //Derteminant stats
    private float currentThrust;
    private float currentBrake;
    private float currentSteer;
    

    //Movement Stats
    [SerializeField] private float thrustForce;
    [SerializeField] private float brakeForce;
    [SerializeField] private float steerForce;
    
    
    
    //Wheeel colliders
    [SerializeField] private WheelCollider frontLeftWheeelCollider;
    [SerializeField] private WheelCollider frontRightWheeelCollider;
    [SerializeField] private WheelCollider rearLeftWheeelCollider;
    [SerializeField] private WheelCollider rearRightWheeelCollider;
    
    //wheel transform
    [SerializeField] private Transform FrontLeftWheeelTransform;
    [SerializeField] private Transform FrontRightWheeelTransform;
    [SerializeField] private Transform rearLeftWheeelTransform;
    [SerializeField] private Transform rearRightWheeelTransform;

    [SerializeField] private AudioSource carSound;
    
    //References
    //public Joystick joystick;
    

    // Update is called once per frame
    void Update()
    {
        MyInput();
        HandleMotor();
        HandleSteering();
        UpdateWheel();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        vertiaclInput = Input.GetAxis(VERTICAL);
        isBreaking = Input.GetKeyDown(KeyCode.Space);
    }

    private void HandleMotor()
    {
        carSound.Play();
        currentThrust = vertiaclInput * thrustForce * Time.deltaTime*500;
        frontLeftWheeelCollider.motorTorque = currentThrust;
        frontRightWheeelCollider.motorTorque = currentThrust;
        rearLeftWheeelCollider.motorTorque = currentThrust;
        rearRightWheeelCollider.motorTorque = currentThrust;

        currentBrake = isBreaking ? brakeForce : 0f;
        ApplyBraking();


    }

    private void ApplyBraking()
    {
        frontLeftWheeelCollider.brakeTorque = currentBrake;
        frontRightWheeelCollider.brakeTorque = currentBrake;
        rearLeftWheeelCollider.brakeTorque = currentBrake;
        rearRightWheeelCollider.brakeTorque = currentBrake;
    }

    private void HandleSteering()
    {
        currentSteer = horizontalInput * steerForce * Time.deltaTime*50;
        frontLeftWheeelCollider.steerAngle = currentSteer;
        frontRightWheeelCollider.steerAngle = currentSteer;
    }

    private void UpdateWheel()
    {
        UpdateSingleWheel(frontLeftWheeelCollider, FrontLeftWheeelTransform);
        UpdateSingleWheel(frontRightWheeelCollider, FrontRightWheeelTransform);
        UpdateSingleWheel(rearLeftWheeelCollider, rearLeftWheeelTransform);
        UpdateSingleWheel(rearRightWheeelCollider, rearRightWheeelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
    }
}
