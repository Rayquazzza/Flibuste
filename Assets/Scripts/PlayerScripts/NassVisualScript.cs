using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NassVisualScript : MonoBehaviour
{
    PlayerMovementScript playerMovementScript;
    private void OnEnable()
    {
        playerMovementScript = GetComponentInParent<PlayerMovementScript>();
        transform.localScale = Vector3.one * 0.7f;
        transform.DOScale(Vector3.one, 0.8f).SetEase(Ease.OutElastic);
    }


    private void Update()
    {
        if (playerMovementScript != null && playerMovementScript.IsHide == false)
        {
            gameObject.SetActive(false);    
        }
            
    }
}
