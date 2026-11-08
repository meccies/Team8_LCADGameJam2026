using UnityEngine;

public class DeliverDistanceCheck : MonoBehaviour
{
    public Transform target;
    public Transform deliverArea;
    public float areaDistance = 2f;

    public bool hasDelivered = false;

    void Start()
    {

    }

    void Update()
    {
        if (hasDelivered) return;
        float distance = Vector3.Distance(target.position, deliverArea.position);

        if (distance <= areaDistance)
        {
            hasDelivered = true;
            Message();
        }
    }

    void Message()
    {
        Debug.Log("Arrived successfully");
    }
}