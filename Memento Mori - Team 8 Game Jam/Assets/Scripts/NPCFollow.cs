using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    //  Add this script to the Gameobject you want to follow you (sprites, NPCs, etc)

    [SerializeField] Transform sprite;

    // This detects when the player walks into the object's trigger collider
    public void OnTriggerEnter(Collider other)
    {
        // Check if the object is the player AND we haven't already started chasing
        if (other.CompareTag("Player"))
        {
            Destroy(sprite);
            Debug.Log("Destroyed");
        }
    }
}