using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingRotationScript : MonoBehaviour
{
    public float rotationAmount = 50f;
    public float rotationSpeed = 1f;

    private Vector3 initialRotation;

    void Start()
    {
        // Fait une rotation en Y de 360° sur 10 secondes
        transform.DORotate(new Vector3(0, 360, 0), 10f, RotateMode.FastBeyond360)
                 .SetEase(Ease.Linear)
                 .SetLoops(-1);
    }

    //void Update()
    //{
    //    float x = Mathf.Sin(Time.time * rotationSpeed) * rotationAmount;
    //    float z = Mathf.Cos(Time.time * rotationSpeed * 0.8f) * rotationAmount;

    //    transform.eulerAngles = initialRotation + new Vector3(x, 0f, z);
    //}
}
