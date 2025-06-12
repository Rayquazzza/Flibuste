using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class FishManagerScript : MonoBehaviour
{
    [SerializeField] private float MinRandom;
    [SerializeField] private float MaxRandom;
    [SerializeField] private GameObject[] FishSpawns;
    [SerializeField] private GameObject Fish;
    private float timer;
    // Start is called before the first frame update


    private void OnEnable()
    {
        EVENTS.OnLevelUp += LevelUp;
    }

    private void OnDisable()
    {
        EVENTS.OnLevelUp -= LevelUp;
    }
    void Start()
    {
        StartCoroutine(WaitForInstantiateFish());
    }

    // Update is called once per frame
    void Update()
    {
        if (GAME.MANAGER.CurrentState == State.Gameplay)
        {
            timer += Time.deltaTime;
        }
        else
        {
            return;
        }
    }


    IEnumerator WaitForInstantiateFish()
    {
        while (true)
        {
            if (GAME.MANAGER.CurrentState == State.Gameplay && timer >= Random.Range(MinRandom, MaxRandom))
            {
                InstantiateFish();
                timer = 0;
            }                
            yield return null;
        }

    }

    void InstantiateFish()
    {
        int index = Random.Range(0, FishSpawns.Length);
        Instantiate(Fish, FishSpawns[index].transform.position, Quaternion.identity);
    }
    void LevelUp()
    {
        MinRandom *= 0.75f;
        MaxRandom *= 0.75f;
    }


}
