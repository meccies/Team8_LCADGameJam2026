using UnityEngine;

public class NPCFollow : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Transform player;
    [SerializeField] float stopDistanceOffset = 2f;

    [SerializeField] int maxChasersAllowed = 1; // Max number of enemies that can follow at once

    // Shared across ALL instances of this script to keep count
    private static int currentChaserCount = 0; 
    
    // Tracks whether the player has touched the object yet
    private bool isChasing = false; 

    void Update()
    {
        // Only move if the player is assigned AND they have touched the object
        if (player != null && isChasing)
        {
            MoveToPlayer();
        }
    }

    public void MoveToPlayer()
    {
        float currentDistance = Vector3.Distance(transform.position, player.position);

        if (currentDistance > stopDistanceOffset)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    // This detects when the player walks into the object's trigger collider
    public void OnTriggerEnter(Collider other)
    {
        // Check if the object is the player AND we haven't already started chasing
        if (!isChasing && (other.transform == player || other.CompareTag("Player")))
        {
            // Only activate if the maximum limit has not been reached yet
            if (currentChaserCount < maxChasersAllowed)
            {
                isChasing = true;
                currentChaserCount++; // Increase the shared global count
                Debug.Log($"Chasing start, {currentChaserCount}/{maxChasersAllowed}");
            }
            else
            {
                Debug.Log("Cannot chase: Maximum limit reached!");
            }
        }
    }

    private void OnDestroy()
    {
        if (isChasing)
        {
            currentChaserCount--;
            // Ensure the count never drops below zero due to unexpected edge cases
            currentChaserCount = Mathf.Max(0, currentChaserCount); 
        }
    }
}