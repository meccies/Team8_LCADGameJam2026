using UnityEngine;

public class NPCSpawnManager : MonoBehaviour
{
    public Transform target;

    void Start()
    {
         Instantiate(target, transform.position, transform.rotation);
    }
}