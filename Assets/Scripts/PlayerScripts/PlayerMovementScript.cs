using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 direction;
    public float Speed;
    public bool IsHide = false;
    private Vector3 InitialPosition;
    NassScript nassScript;
    // Start is called before the first frame update
    void Start()
    {        
        InitialPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        direction = Vector3.zero;
        nassScript = GetComponentInChildren<NassScript>();
    }

    private void OnEnable()
    {
        EVENTS.OnGameStart += ResetPosition;
    }

    private void OnDisable()
    {
        EVENTS.OnGameStart -= ResetPosition;
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

    public void Hide()
    {
        direction = Vector3.zero ;

        if (nassScript != null) nassScript.HideWithNass();
        else if (nassScript == null) Debug.Log("CA EXISTE PAS");

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision détectée avec : " + collision.gameObject.name);
    }

    void ResetPosition()
    {
        transform.position = InitialPosition;
    }
}
