using System.Collections;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{

    // Add this script to your Dialogue panel
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    public int index;

    // Removed StartDialogue() from here so it doesn't run on spawn
    public void Start()
    {
        textComponent.text = string.Empty;
        gameObject.SetActive(false);
        //StartDialogue();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public void StartDialogue()
    {
        gameObject.SetActive(true);
        textComponent.text = string.Empty;
        index = 0;
        StartCoroutine(TypeLine());
    }

    public IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            // Clear text when done so it can be clicked and replayed later
            textComponent.text = string.Empty; 
            // Note: If you deactivate the gameObject here, you won't be able to click the sprite again unless something else reactivates it!
            gameObject.SetActive(false); 
        }
    }
}