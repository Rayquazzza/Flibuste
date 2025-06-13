using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class NassScript : MonoBehaviour
{
    PlayerMovementScript playerMovementScript;
    [SerializeField] private GameObject Nass;
    // Start is called before the first frame update
    private void Start()
    {
        playerMovementScript = FindAnyObjectByType<PlayerMovementScript>();
        Nass.SetActive(false);
    }



    public void HideWithNass()
    {
        Nass.SetActive(true);       
    }
}
