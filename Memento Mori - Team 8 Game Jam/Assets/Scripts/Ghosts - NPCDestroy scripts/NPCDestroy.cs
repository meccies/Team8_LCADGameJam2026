using UnityEngine;

public class NPCDestroy : MonoBehaviour
{
    // Attach this script to your Trigger Area GameObject
    private void OnTriggerEnter(Collider other)
    {
            // Find every active NPCFollow script in the scene
            NPCFollow[] followers = Object.FindObjectsByType<NPCFollow>();

            // Loop through each one and destroy its GameObject
            foreach (NPCFollow npc in followers)
            {
                // Optional: Check if they are actually following the player (e.g., if you have a bool variable like npc.isFollowing)
                if (npc.isChasing) 
                {
                    Debug.Log("Sprite destroyed");
                    Destroy(npc.gameObject);
                    
                }
            }
        }
    }