using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    // A static variable keeps its value across all objects using this script
    public static int score = 0;

    // Define your maximum score here
    public int maxScore = 10;

    // This handles 3D trigger zones (if "Is Trigger" is checked on your Collider)
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Only increase the score if it hasn't reached the max limit yet
            if (score < maxScore)
            {
                score++;
                Debug.Log("Object collected! Current Score: " + score + " / " + maxScore);

                // Check if the player just hit the maximum score
                if (score == maxScore)
                {
                    Debug.Log("Max score reached! You win!");
                }
            }
            else
            {
                Debug.Log("Max score already reached! Score remains at: " + score);
            }

            // Destroy this object
            Destroy(gameObject);
        }
    }
}
