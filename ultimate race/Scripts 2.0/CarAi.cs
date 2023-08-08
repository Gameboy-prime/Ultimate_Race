using UnityEngine;

public class CarAi : MonoBehaviour
{
        
    private const string VERTICAL = "Vertical";
    private const string HORIZONTAL = "Horizontal";
    
    private float currentBrakeForce;
    private float horizontalInput;
    private float verticalInput;
    private bool isBreaking;
    private float currentSteer;

    private Vector3 targetPos;
   
    [SerializeField] private float thrustForce;
    [SerializeField] private float brakeForce;
    [SerializeField] private float steerForce;
    [SerializeField] private float rotspeed;

    [SerializeField] private WheelCollider frontRightWheelCollider;
    [SerializeField] private WheelCollider frontLeftWheelCollider;
    [SerializeField] private WheelCollider rearRightWheelCollider;
    [SerializeField] private WheelCollider rearLeftWheelCollider;

    [SerializeField] private Transform frontRightWheelTransform;
    [SerializeField] private Transform frontLeftWheelTransform;
    [SerializeField] private Transform rearRightWheelTransform;
    [SerializeField] private Transform rearLeftWheelTransform;

    [SerializeField] private GameObject aim;


    private Transform target;
    
    

    
    private void Update()
    {
        
        
        
        
        //FaceTracker();
       
        //HandleMotor();
        //HandleSteering();
        UpdateWheels();
        //Invoke("ApplyBraking",3.5f);
    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        isBreaking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {
        target = aim.transform;
        SetTargetPos(target.position);

        Vector3 dirToMoveToPos = (target.position-transform.position).normalized;
        float dot= Vector3.Dot(transform.position, dirToMoveToPos);
        Debug.Log(dot);

        if (dot > 0)
        {
            thrustForce = thrustForce*1;
        }
        else
        {
            thrustForce = thrustForce * -1;
        }
        frontRightWheelCollider.motorTorque = thrustForce ;
        frontLeftWheelCollider.motorTorque = thrustForce ;
        rearRightWheelCollider.motorTorque = thrustForce;
        rearLeftWheelCollider.motorTorque = thrustForce ;
        currentBrakeForce = brakeForce;


    }

    public void ApplyBraking()
    {
        
        
        frontRightWheelCollider.brakeTorque = currentBrakeForce;
        frontLeftWheelCollider.brakeTorque= currentBrakeForce;
        rearRightWheelCollider.brakeTorque = currentBrakeForce;
        rearLeftWheelCollider.brakeTorque = currentBrakeForce;
    }

    private void HandleSteering()
    {
        target = aim.transform;
        SetTargetPos(target.position);
        Vector3 dirToMoveToPos = (target.position-transform.position).normalized;
        float angleDir = Vector3.SignedAngle(transform.forward, dirToMoveToPos, Vector3.up);

        if (angleDir > 0)
        {
            steerForce = steerForce * 1;
        }
        else
        {
            steerForce = steerForce * -1;
        }
        currentSteer =steerForce;
        frontLeftWheelCollider.steerAngle = currentSteer ;
        frontRightWheelCollider.steerAngle = currentSteer ;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(rearRightWheelCollider, rearRightWheelTransform);
        UpdateSingleWheel(rearLeftWheelCollider, rearLeftWheelTransform);
        //UpdateSingleWheelFront(frontLeftWheelCollider, frontLeftWheelTransform);
        //UpdateSingleWheelFront(frontRightWheelCollider, frontRightWheelTransform);
        
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.position = pos;
        wheelTransform.rotation = rot;
        
        
    }
    
    private void FaceTracker()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion rot = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation,rot,Time.deltaTime*rotspeed);
    }

    public void SetTargetPos(Vector3 targetPos)
    {
        this.targetPos = targetPos;
    }
    
}
