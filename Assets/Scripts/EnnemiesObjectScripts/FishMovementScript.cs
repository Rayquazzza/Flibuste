using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

public class FishMovementScript : MonoBehaviour
{
    private PlayerCollisionScript Player;
    private Vector3 direction;
    private Rigidbody rb;
    public bool Hascollide;

    [SerializeField] private float speed;   
    private void OnEnable()
    {
        Hascollide = false;
        Player = FindAnyObjectByType<PlayerCollisionScript>();
        rb = GetComponent<Rigidbody>();                               
        StartCoroutine(Movement());
    }

    IEnumerator Movement()
    {
        while (true)
        {
            if(Hascollide == false)
            {
                rb.position = Vector3.MoveTowards(rb.position, Player.gameObject.transform.position, speed * Time.deltaTime);                
            }
            else if (Hascollide == true)
            {
                Vector3 oppositeDirection = (rb.position - Player.gameObject.transform.position).normalized;
                rb.position += oppositeDirection * speed * Time.deltaTime;
            }
            yield return null;
        }       
    }
}
