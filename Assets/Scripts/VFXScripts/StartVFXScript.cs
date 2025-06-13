using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class StartVFXScript : MonoBehaviour
{
   [SerializeField] private VisualEffect VFXrecupObjet;

    private void Start()
    {
    }
    public void StartVFX()
    {
        VFXrecupObjet.Play();
    }


}
