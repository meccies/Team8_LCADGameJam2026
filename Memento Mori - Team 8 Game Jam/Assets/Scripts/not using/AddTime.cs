using UnityEngine;

public class AddTime : MonoBehaviour
{
    //Add this script to the Object with the trigger collider, in this case the Soul sprite

    public float timeToAdd = 5f; // Amount of seconds to add

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the Player
        if (other.CompareTag("Player"))
        {
            // Find the TimerManager in the scene and add time
            TimerManager timer = FindAnyObjectByType<TimerManager>();
            if (timer != null)
            {
                timer.AddBonusTime(timeToAdd);
                Destroy(gameObject); // Destroy the pickup item
            }
        }
    }
}