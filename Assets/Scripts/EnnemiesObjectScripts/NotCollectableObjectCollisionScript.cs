using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotCollectableObjectCollisionScript : MonoBehaviour, ICollidable
{
    [SerializeField] private GameObject VFXTakeDamage;
    public void OnCollision(Collider collison)
    {
     
    }

    private void OnTriggerEnter(Collider other)
    {
        HealthPlayerScript collidable = other.GetComponentInParent<HealthPlayerScript>();
        if (collidable != null)
        {
            if(VFXTakeDamage != null)
            {
                Instantiate(VFXTakeDamage,other.gameObject.transform.position, Quaternion.identity);
            }
            Debug.Log(other.gameObject.name);
            collidable.TakeDamage();
            Destroy(gameObject);
        }
    }
}
