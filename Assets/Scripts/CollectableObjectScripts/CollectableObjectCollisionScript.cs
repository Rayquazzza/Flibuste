using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX; 

public class CollectableObjectCollisionScript : MonoBehaviour, ICollidable
{
    CollectableObjectMovementScript com_Script;
    ScoreManagerScript scoremanager;
    [SerializeField] VisualEffect VFXrecupObjet; 
    private void OnEnable()
    {
        scoremanager = FindAnyObjectByType<ScoreManagerScript>();
        com_Script = GetComponent<CollectableObjectMovementScript>();
    }
    public void OnCollision(Collider collider)
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // CollisionForObjectScript collision = other.GetComponent<CollisionForObjectScript>();
        if (other.gameObject.layer == 6)
        {
            Debug.Log("Trigger Test");
            scoremanager.AddScore(com_Script.scoreAmount);
            GameObject.FindGameObjectWithTag("VFXPlayer").GetComponent<StartVFXScript>().StartVFX();
            Destroy(gameObject);    
        }
    }
}
