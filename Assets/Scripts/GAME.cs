using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAME : MonoBehaviour
{
    public State CurrentState;

    public static GAME MANAGER;

    public void EnterState(State newState)
    {
        if (CurrentState == newState) return;
        CurrentState = newState;
        switch (CurrentState)
        {
            case State.Start: break;
            case State.End: break;
            case State.Gameplay:break;
        }
    }

    private void Awake()
    {
        MANAGER = this; // Référence correcte à l'instance actuelle
    }

    void OnEnable()
    {
        DestroyIfDuplicate(); // Security to prevent multiple game managers
    }
    void DestroyIfDuplicate()
    {
        if (MANAGER != null && MANAGER != this)
        {
            Debug.Log("ERROR! MORE THAN ONE GAME MANAGER IN SCENE!");
            DestroyImmediate(gameObject);
        }
    }


    public void GameOver()
    {
        EVENTS.InvokeGameEnd();
    }
}
