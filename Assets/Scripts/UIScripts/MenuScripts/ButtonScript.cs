using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private float transitionDuration;
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(new Vector3(1.4f, 1.4f, 1f), transitionDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(Vector3.one , transitionDuration);
    }
}
