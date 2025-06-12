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
        transform.DOScale(new Vector3(5f, 5f, 1f), transitionDuration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(new Vector3(4f, 4f, 1f), transitionDuration);
    }
}
