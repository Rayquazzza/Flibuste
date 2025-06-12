using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class CollectableObjectManagerScript : MonoBehaviour
{
    [SerializeField] private float minrandom;
    [SerializeField] private float maxrandom;
    public GameObject[] CollectableObjects;
    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnEnable()
    {
        EVENTS.OnGameStart += LaunchInstantiateCoroutine;
        EVENTS.OnLevelUp += LevelUpDifficulty;
    }

    private void OnDisable()
    {
        EVENTS.OnGameStart -= LaunchInstantiateCoroutine;
        EVENTS.OnLevelUp -= LevelUpDifficulty;
    }

    void InstantiateObjectAtRandomPosition()
    {
        int randomindex = Random.Range(0,CollectableObjects.Length);
        Vector3 randomposition = new Vector3(Random.Range(-9,9),transform.position.y,0);
        Instantiate(CollectableObjects[randomindex],randomposition,Quaternion.identity);
    }


    IEnumerator InstantiateCoroutine()
    {
        while(GAME.MANAGER.CurrentState == State.Gameplay)
        {            
            InstantiateObjectAtRandomPosition();
            yield return new WaitForSeconds(Random.Range(minrandom,maxrandom));
        }
    }

    void LaunchInstantiateCoroutine()
    {
        StartCoroutine(InstantiateCoroutine());
    }
    
    public void LevelUpDifficulty()
    {
        minrandom *= 0.8f;
        maxrandom *= 0.8f;
    }
}
