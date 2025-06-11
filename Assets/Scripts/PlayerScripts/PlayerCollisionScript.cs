using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour,ICollidable,ICollisionable
{
    public void OnCollide(Collision collision, GameObject sender)
    {

    }
    public void OnCollision(Collider collision)
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        ICollidable collectable = other.GetComponent<ICollidable>();
        if (collectable != null)
        {
            collectable.OnCollision(other);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        ICollisionable collide = collision.gameObject.GetComponent<ICollisionable>();
        if (collide != null)
        {
            // On passe aussi ce GameObject (le joueur) manuellement
            collide.OnCollide(collision, this.gameObject);
        }
    }
}
