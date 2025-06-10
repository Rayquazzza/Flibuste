using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CollectableObjectMovementScript : MonoBehaviour,ICollidable
{

    [SerializeField] int ScoreAmount;
    [SerializeField] int speed;
    private Vector3 direction;


    private void Start()
    {
        direction = Vector3.down;
    }
    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        if (transform.position.y == 0)
        {
            direction = Vector3.zero;
        }
    }

    public void OnCollision(Collider collider)
    {
        Debug.Log(ScoreAmount);
        Destroy(gameObject);
    }
}
