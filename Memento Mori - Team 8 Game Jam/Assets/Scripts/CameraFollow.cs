using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   [SerializeField] Transform cameraTarget;
   [SerializeField] Vector3 offset = new Vector3(0, 0, -10);

    void LateUpdate()
    {
        transform.position = cameraTarget.position + offset;
        transform.LookAt(cameraTarget);
    }
}

// NOTE TO SELF: apply this script to your CAMERA, not your player GameObject