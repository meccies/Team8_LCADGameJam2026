using UnityEngine;

public class NPCManager : MonoBehaviour
{
    // Place in player gameobject due to OnTriggerEnter method
    public GameObject soulSprite;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(soulSprite, 0.1f);
        Debug.Log("Destroyed");
    }
}
