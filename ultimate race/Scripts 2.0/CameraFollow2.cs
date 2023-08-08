using UnityEngine;

public class CameraFollow2 : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    [SerializeField] private float camera_x;
    [SerializeField] private float camera_y;
    [SerializeField] private float camera_z;

    // Update is called once per frame
    void Update()
    {
        camera_x = camera.transform.eulerAngles.x;
        camera_y = camera.transform.eulerAngles.y;
        camera_z = camera.transform.eulerAngles.z;
        transform.eulerAngles= new Vector3(camera_x-camera_x,camera_y,camera_z-camera_z);
    }
}
