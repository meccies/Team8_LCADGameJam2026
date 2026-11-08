using System.Diagnostics.Contracts;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    // Place in player gameobject due to OnTriggerEnter method, select sprite and time manager in slot
    public GameObject soulSprite;
    public float timeToAdd = 5f;

    public TimerManager timerManager;

    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

         TimerManager timer = FindAnyObjectByType<TimerManager>();

        if (timer != null)
        {
            timer.AddBonusTime(timeToAdd);
            Destroy(soulSprite, 0.1f);
            Debug.Log("Destroyed"); 
        }
        

    }
}
