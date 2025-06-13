using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverManagerScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoreText;
    ScoreManagerScript score;
    private void OnEnable()
    {
        EVENTS.OnGameEnd += DisplayScore;
    }

    private void OnDisable()
    {
        EVENTS.OnGameEnd -= DisplayScore;
    }


    void DisplayScore()
    {
        Debug.Log("CA APPELLE");
        score = FindAnyObjectByType<ScoreManagerScript>();
        if(score != null)
        {
            ScoreText.text = "Your Score : " + score.scoreCount.ToString();
        }
        else
        {
            Debug.Log("BAH C NULL");
        }
    }
}
