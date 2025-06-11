using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayerScript : MonoBehaviour
{
    HealthManager healthManager;
    private void Start()
    {
        healthManager = FindAnyObjectByType<HealthManager>();   
    }

    public void TakeDamage()
    {
        healthManager.LoseLife();
    }
}
