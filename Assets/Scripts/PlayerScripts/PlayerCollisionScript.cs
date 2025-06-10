using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionScript : MonoBehaviour,ICollidable
{
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
}
