using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDownTweeningScript : MonoBehaviour
{
    [SerializeField] private float moveDistance = 50f;
    [SerializeField]private float duration = 2f;
    private RectTransform rectTrans;
    // Start is called before the first frame update
    void Start()
    {
        rectTrans = GetComponent<RectTransform>();

        Vector3 originalPos = rectTrans.localPosition;

        Vector3 targetPos = new Vector3(originalPos.x, originalPos.y - moveDistance, originalPos.z);

        rectTrans.DOLocalMoveY(targetPos.y, duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }
}
