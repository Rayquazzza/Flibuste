using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObjectManagerScript : MonoBehaviour
{
    public GameObject[] CollectableObjects;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiateCoroutine());
    }

    void InstantiateObjectAtRandomPosition()
    {
        int randomindex = Random.Range(0,CollectableObjects.Length);
        Vector3 randomposition = new Vector3(Random.Range(-10,10),transform.position.y,0);
        Instantiate(CollectableObjects[randomindex],randomposition,Quaternion.identity);
    }


    IEnumerator InstantiateCoroutine()
    {
        while(true)
        {
            InstantiateObjectAtRandomPosition();
            yield return new WaitForSeconds(Random.Range(2,4));
        }
        
    }

    





   
}
