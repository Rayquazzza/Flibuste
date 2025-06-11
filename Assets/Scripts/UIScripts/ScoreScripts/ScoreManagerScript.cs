using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
public class ScoreManagerScript : MonoBehaviour
{
    TextMeshProUGUI Score;
    int scoreCount = 0;

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
}
