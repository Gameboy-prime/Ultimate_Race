using UnityEngine;
using UnityEngine.UIElements;

public class CarController : MonoBehaviour
{
        
    private const string VERTICAL = "Vertical";
    private const string HORIZONTAL = "Horizontal";
    
    private float currentBrakeForce;
    private float horizontalInput;
    private float verticalInput;
    private bool isBreaking;
    private float currentSteer;

   
    
    public float thrustForce;
    [SerializeField] private float brakeForce;
    [SerializeField] private float steerForce;

    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;

    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;
    
    

    
    private void FixedUpdate()
    {
        GetInput();
        HandleMotor(verticalInput, thrustForce);
        HandleSteering(horizontalInput, steerForce);
        UpdateWheels();
        
       
        
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor(float vertical, float thrustValue)
    {
        //frontRightWheelCollider.motorTorque = vertical * thrustValue * Time.deltaTime *50;
        //frontLeftWheelCollider.motorTorque = vertical * thrustValue * Time.deltaTime*50;
        rearRightWheelCollider.motorTorque = vertical * thrustValue * Time.deltaTime*50;
        rearLeftWheelCollider.motorTorque = vertical * thrustValue * Time.deltaTime*50;        
        currentBrakeForce = isBreaking ? brakeForce : 0f;
        ApplyBraking();

    }

    public void ApplyBraking()
    {
        frontRightWheelCollider.brakeTorque = currentBrakeForce;
        frontLeftWheelCollider.brakeTorque= currentBrakeForce;
        rearRightWheelCollider.brakeTorque = currentBrakeForce;
        rearLeftWheelCollider.brakeTorque = currentBrakeForce;
        
    }

    private void HandleSteering(float horizontal, float steerValue)
    {
        currentSteer = horizontal * steerValue * Time.deltaTime*10;
        frontLeftWheelCollider.steerAngle = currentSteer * Time.deltaTime*50;
        frontRightWheelCollider.steerAngle = currentSteer* Time.deltaTime*50;
    }

    

   

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
        
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
