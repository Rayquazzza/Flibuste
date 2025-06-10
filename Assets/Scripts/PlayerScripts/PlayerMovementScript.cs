using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 direction;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * Speed * Time.fixedDeltaTime);
    }


    public void MoveLeft()
    {
        direction = Vector3.left;
    }

    public void MoveRight()
    {
        direction = Vector3.right;
    }

    public void Stop()
    {
        direction = Vector3.zero;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision détectée avec : " + collision.gameObject.name);
    }

}
