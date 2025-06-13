using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{

    private void OnEnable()
    {
        EVENTS.OnGameStart += ResetLife;
    }

    private void OnDisable()
    {
        EVENTS.OnGameStart -= ResetLife;
    }
    [SerializeField] private Image[] Healths;
    [SerializeField] int life = 3;
    public void LoseLife()
    {
        Debug.Log("A Perdu de la vie");
        if (life > 0)
        {
            // Décrémente la vie
            life--;

            // Désactive le cœur correspondant
            Healths[life].enabled = false;

            // Ici, vous pouvez ajouter d'autres actions si le joueur n'a plus de vie
            if (life == 0)
            {               
                GAME.MANAGER.GameOver();
            }
        }
    }

    void ResetLife()
    {
        life = 3;
        foreach (Image heart in Healths)
        {
            heart.enabled = true;
        }

    }
}
