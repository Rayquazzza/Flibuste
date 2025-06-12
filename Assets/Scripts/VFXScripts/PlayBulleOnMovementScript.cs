using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBulleOnMovementScript : MonoBehaviour
{
    private Vector3 InitialPosition;
    [SerializeField] private GameObject fx_Bulle;
    // Start is called before the first frame update
    void Start()
    {
        InitialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(InitialPosition, transform.position) >= 2)
        {
            if (fx_Bulle) Instantiate(fx_Bulle, transform.position + Vector3.up * 0.5f, Quaternion.identity);
            InitialPosition = transform.position;
        }
    }
}
