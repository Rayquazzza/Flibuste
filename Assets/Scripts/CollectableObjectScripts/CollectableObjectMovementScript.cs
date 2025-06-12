using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CollectableObjectMovementScript : MonoBehaviour
{

    [SerializeField] private int ScoreAmount;
    public int scoreAmount
    {
        get { return ScoreAmount; }
    }
    [SerializeField] float speed;
    private Vector3 direction;

    private void OnEnable()
    {
        EVENTS.OnLevelUp += levelUp;
    }
    private void OnDisable()
    {
        EVENTS.OnLevelUp -= levelUp;
    }
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

    void levelUp()
    {
        speed *= 1.5f;
    }
}
