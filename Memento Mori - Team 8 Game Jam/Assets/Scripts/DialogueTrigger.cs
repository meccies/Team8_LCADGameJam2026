using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    // add this script to sprite NPCs
    public Dialogue dialogueBox;

    public void OnTriggerEnter(Collider other)
    {
        dialogueBox.StartDialogue();
    
    }
}
