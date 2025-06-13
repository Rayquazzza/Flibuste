using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class ScoreManagerScript : MonoBehaviour
{
    TextMeshProUGUI Score;
    public int scoreCount = 0;
    private void OnEnable()
    {
        EVENTS.OnGameStart += ResetScore;
    }
    private void OnDisable()
    {
        EVENTS.OnGameStart -= ResetScore;
    }

    private void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();
    }

    public void AddScore(int amount)
    {
        scoreCount = scoreCount + amount; 
        Score.text = scoreCount.ToString();
        // Réduire brièvement avant l'effet "boing"
        Score.transform.localScale = Vector3.one * 0.8f;
        Score.transform.DOScale(Vector3.one, 0.8f).SetEase(Ease.OutElastic);
    }

    void ResetScore()
    {
        scoreCount = 0;
        Score.text = scoreCount.ToString();
    }
}
