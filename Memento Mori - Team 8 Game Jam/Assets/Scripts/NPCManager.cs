using System.Diagnostics.Contracts;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    // Place in player gameobject due to OnTriggerEnter method, select sprite and time manager in slot
    public GameObject sprite;
    public float timeToAdd = 5f;

    public TimerManager timerManager;

    void Start()
    {
        
    }

    //public void OnTriggerEnter(Collider other)
    //{

         //TimerManager timer = FindAnyObjectByType<TimerManager>();

        //if (timer != null && other.CompareTag("Player"))
        //{
            //timer.AddBonusTime(timeToAdd);
            //Destroy(sprite, 0.1f);
           // Debug.Log("Sprite destroyed"); 
       // }
        

   // }
}
