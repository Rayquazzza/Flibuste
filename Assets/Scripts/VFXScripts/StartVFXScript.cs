using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class StartVFXScript : MonoBehaviour
{
   [SerializeField] private VisualEffect VFXrecupObjet; 
    
    public void StartVFX()
    {
        VFXrecupObjet.Play();
    }


}
