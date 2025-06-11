using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollisionable
{
    void OnCollide(Collision collision, GameObject sender);
}
