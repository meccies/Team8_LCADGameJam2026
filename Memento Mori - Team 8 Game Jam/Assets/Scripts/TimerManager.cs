using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public TMP_Text timerText;
    public float countdown = 35f; // Time in seconds

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
