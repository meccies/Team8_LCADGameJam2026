using UnityEngine;

public class EndingCheck : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform winArea;

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("EndCheckObject");
        Debug.Log("Area Reached");
    }
}