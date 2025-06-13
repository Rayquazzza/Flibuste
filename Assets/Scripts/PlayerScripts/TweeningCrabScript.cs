using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweeningCrabScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = Vector3.one * 0.85f;
        transform.DOScale(Vector3.one, 0.8f)
            .SetEase(Ease.InOutElastic) // ou InOutSine si tu veux plus doux
            .SetLoops(-1, LoopType.Yoyo);
    }

  
}
