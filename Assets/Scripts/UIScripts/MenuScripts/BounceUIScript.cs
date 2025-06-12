using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceUIScript : MonoBehaviour
{
    private RectTransform rect;

    private void OnEnable()
    {
        rect = GetComponent<RectTransform>();
        rect.localScale = Vector3.one * 0.5f;
        rect.DOScale(Vector3.one, 0.8f).SetEase(Ease.OutElastic);
    }
}
