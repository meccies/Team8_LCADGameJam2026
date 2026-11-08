using UnityEngine;

public class NPCDestroy : MonoBehaviour
{

    // Place this script in trigger collission obj

    public GameObject sprite;

    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        NPCFollow chaser = FindAnyObjectByType<NPCFollow>();

        if (chaser != null)
        {
            Destroy(sprite, 0.1f);
            Debug.Log("Sprite destroyed"); 
        }

    }
}