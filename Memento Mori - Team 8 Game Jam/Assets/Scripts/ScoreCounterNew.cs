using UnityEngine;
using TMPro; // Required for TextMeshPro components

public class ScoreCounter : MonoBehaviour
{
    // Reference to the UI Text component
    public TextMeshProUGUI counterText; 
    
    private int currentCount = 0;

    void Start()
    {
        // Initialize the UI text at the beginning of the game
        UpdateUI();
    }

    // Call this public method whenever you want to increase the counter
    public void AddPoint(int amount)
    {
        currentCount += amount;
        UpdateUI(); // Update the display immediately when data changes
    }

    // Separating UI logic avoids cluttering your core gameplay loop
    void UpdateUI()
    {
        counterText.text = "Score: " + currentCount.ToString();
    }
}
