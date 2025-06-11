using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEditor.UI;
using UnityEngine;

public class FishMovementScript : MonoBehaviour
{
    private PlayerCollisionScript Player;
    private float Distance;
    private Vector3 direction;
    private Rigidbody rb;
    [SerializeField] private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Player = FindAnyObjectByType<PlayerCollisionScript>();
        Distance = transform.position.x - Player.gameObject.transform.position.x;
    }

    private void OnEnable()
    {
        if (Distance >= 0)
        {
            direction = Vector3.left;
        }
        else if (Distance <= 0)
        {
            direction = Vector3.right;
        }                                
        StartCoroutine(Movement());
    }

    IEnumerator Movement()
    {
        while (true)
        {
            rb.MovePosition(rb.position + direction * speed * Time.deltaTime);  
            yield return null;
        }       
    }
}
