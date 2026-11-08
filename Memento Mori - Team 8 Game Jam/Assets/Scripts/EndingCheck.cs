using UnityEngine;

public class EndingCheck : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform winArea;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Area Reached");
        }

    }
}