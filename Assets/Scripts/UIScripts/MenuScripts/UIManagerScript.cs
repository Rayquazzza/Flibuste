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
        StartCoroutine(LaunchGameRoutine());
    }

    public void StartGame()
    {
        StartCoroutine(StartGameRoutine());       
    }
    public void ExitGame()
    {
        StartCoroutine(ExitGameRoutine());      
    }
    private IEnumerator LaunchGameRoutine()
    {
        yield return null;
        // Démarre l’animation de transition
        //yield return StartCoroutine(SceneController.instance.LoadLevel());

        // Patiente encore un peu après la transition si tu veux
        //yield return new WaitForSeconds(0.2f);

        // Puis masque les menus et passe au gameplay
        HideAllMenus();
        GameplayUI.SetActive(true);
        GAME.MANAGER.EnterState(State.Gameplay);
        EVENTS.InvokeGameStart();
    }

    private IEnumerator StartGameRoutine()
    {
        // Démarre l’animation de transition
        yield return StartCoroutine(SceneController.instance.LoadLevel());

        // Patiente encore un peu après la transition si tu veux
        //yield return new WaitForSeconds(0.2f);

        // Puis masque les menus et passe au gameplay
        HideAllMenus();
        TutorialUI.SetActive(true);
    }
    private IEnumerator ExitGameRoutine()
    {
        // Démarre l’animation de transition
        yield return StartCoroutine(SceneController.instance.LoadLevel());

        // Patiente encore un peu après la transition si tu veux
        //yield return new WaitForSeconds(0.2f);

        // Puis masque les menus et passe au gameplay
        HideAllMenus();
        GameOverMenu?.SetActive(true);
        GAME.MANAGER.EnterState(State.End);
    }
}
