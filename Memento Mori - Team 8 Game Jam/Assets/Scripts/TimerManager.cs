using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    //public GameObject smallSouls;
    //public GameObject majorSouls;
    public TMP_Text timerText;
    public float countdown = 5f; // Time in seconds
    
    public NPCManager nPCManager;

    void Start()
    {
    
    }

    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown < 0f)
        {
            countdown = 0f;
        }
        
        float seconds = Mathf.FloorToInt(countdown % 60);
        timerText.text = string.Format("{0:00}", seconds);
        
    }

}

// Make empty GameObejct "TimeManager" and add this script in there