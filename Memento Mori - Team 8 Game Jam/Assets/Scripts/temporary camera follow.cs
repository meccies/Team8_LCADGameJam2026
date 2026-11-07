using UnityEngine;

public class temporarycamerafollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 0, -10);

    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}

// REMEMBER TO REMOVE/DELETE THIS WHEN DONE..this is just so i can see the level in game view better