using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class NotCollectableObjectCollisionScript : MonoBehaviour, ICollidable
{
    public void OnCollision(Collider collison)
    {
     
    }

    private void OnTriggerEnter(Collider other)
    {
        HealthPlayerScript collidable = other.GetComponentInParent<HealthPlayerScript>();
        if (collidable != null)
        {
            Debug.Log(other.gameObject.name);
            collidable.TakeDamage();
            Destroy(gameObject);
        }
    }
}
