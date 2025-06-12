using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotCollectableObjectScript : MonoBehaviour
{
    [SerializeField] int speed;
    private Vector3 direction;


    private void Start()
    {
        direction = Vector3.down;
    }
    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        if (transform.position.y <= -5)
        {
            Destroy(gameObject);
        }
    }
}
