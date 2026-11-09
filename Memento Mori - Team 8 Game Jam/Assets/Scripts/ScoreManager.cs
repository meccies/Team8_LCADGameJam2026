using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Attach this script to ghost npc gameobject & apply ScoreCollider tag to ghost sprites(?
    // Select "current score" TMP
    // For SFX, attach an Audio Source component to the desired GameObject and attach the sound you imported in to said component

    public TMP_Text currentScore;
    public int score = 0;
    public int maxScore = 1;

    //public NPCFollow nPCFollow;


    //public bool hasTriggered = false;
    //public TimerManager timeScript;

    public void Start()
    {
        //nPCFollow = GetComponent<NPCFollow>();
    }

    public void AddScore(int amount)
    {
        if (score <= maxScore)
        {
            score += amount;
            //AddBonusTime(1f);
        }

        if (score >= maxScore)
        {
            SceneManager.LoadScene("Win Screen");
            Debug.Log("Max score reached");
        }

        currentScore.text = score.ToString();
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AddScore(1);
            Debug.Log("You win");
           // Destroy(other.gameObject);
        }

// put variables from NPCFollow in score count (make public), if statement to add score
    }
}