using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform cameraTarget;
    [SerializeField] Camera mainCamera;
    [SerializeField] float speed = 2f;
    [SerializeField] float rotationSpeed = 2f;
    [SerializeField] Vector3 offset = new Vector3(0, 0, -10);

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        FollowMouse();
    }

    void LateUpdate()
    {
        transform.position = cameraTarget.position + offset;
        transform.LookAt(cameraTarget);
    }

    private void FollowMouse()
    {
        // This moves and rotates the camera with your mouse cursor

        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = mainCamera.nearClipPlane;
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        worldPosition.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, worldPosition, speed * Time.deltaTime);

        float horizontal = Input.GetAxis("Mouse X") * rotationSpeed;
        float vertical = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.Rotate(0, horizontal, 0);
        transform.Rotate(-vertical, 0, 0);

    }
}

// NOTE TO SELF: apply this script to your CAMERA, not your player GameObject