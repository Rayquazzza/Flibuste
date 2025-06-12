using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerScript : MonoBehaviour
{
    [SerializeField] GameObject StartMenu, GameOverMenu, GameplayUI, TutorialUI;

    private void Start()
    {
        EVENTS.InvokeInitialization();
    }
    private void OnEnable()
    {
        EVENTS.OnInitialization += ShowStartMenu;
        EVENTS.OnGameEnd += ExitGame;
    }

    private void OnDisable()
    {
        EVENTS.OnInitialization -= ShowStartMenu;
        EVENTS.OnGameEnd -= ExitGame;
    }

    public void ShowStartMenu()
    {
        HideAllMenus();
        StartMenu.SetActive(true);
        GAME.MANAGER.EnterState(State.Start);
    }

    public void HideAllMenus()
    {
        Debug.Log("HideAllMenus");
        AllMenus(false);
    }

    public void AllMenus(bool wanted)
    {
        StartMenu.SetActive(wanted);
        GameOverMenu.SetActive(wanted);
        TutorialUI.SetActive(wanted);
    }

    public void LaunchGame()
    {
        HideAllMenus();
        GameplayUI.SetActive(true);
        GAME.MANAGER.EnterState(State.Gameplay);
        EVENTS.InvokeGameStart();
    }

    public void StartGame()
    {
        HideAllMenus();
        TutorialUI.SetActive(true);
    }
    public void ExitGame()
    {
        HideAllMenus();
        GameOverMenu?.SetActive(true);
        GAME.MANAGER.EnterState(State.End);
    }
}
