using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObjectCollisionScript : MonoBehaviour, ICollidable
{
    CollectableObjectMovementScript com_Script;
    ScoreManagerScript scoremanager;
    private void OnEnable()
    {
        scoremanager = FindAnyObjectByType<ScoreManagerScript>();
        com_Script = GetComponent<CollectableObjectMovementScript>();
    }
    public void OnCollision(Collider collider)
    {
        scoremanager.AddScore(com_Script.scoreAmount);
        Destroy(gameObject);
    }
}
