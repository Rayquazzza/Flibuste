using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FishCollisionScript : MonoBehaviour, ICollisionable
{
    FishMovementScript m_Script;
    PlayerMovementScript m_ScriptPlayer;
    private void OnEnable()
    {
        m_ScriptPlayer = FindAnyObjectByType<PlayerMovementScript>();
        m_Script = GetComponent<FishMovementScript>();
    }
    public void OnCollide(Collision collision, GameObject sender)
    {
        m_Script.Hascollide = true;
        Debug.Log("Objet en Collision (envoyé) : " + sender.name); // Affiche enfin le nom du joueur
        HealthPlayerScript Playercollision = sender.GetComponent<HealthPlayerScript>();
        if (Playercollision != null)
        {
            if (m_ScriptPlayer.IsHide == true) return;
            Playercollision.TakeDamage();
        }
        else
        {
            Debug.Log("Bah non c'est null");
        }
    }

}
