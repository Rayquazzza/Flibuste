using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerScript : MonoBehaviour
{
    [SerializeField] GameObject StartMenu, GameOverMenu, GameplayUI;

    private void Start()
    {
        EVENTS.InvokeInitialization();
    }
    private void OnEnable()
    {
        EVENTS.OnInitialization += ShowStartMenu;
    }

    private void OnDisable()
    {
        EVENTS.OnInitialization -= ShowStartMenu;
    }

    public void ShowStartMenu()
    {
        HideAllMenus();
        StartMenu.SetActive(true);
        
    }

    public void HideAllMenus()
    {
        AllMenus(false);
    }

    public void AllMenus(bool wanted)
    {
        StartMenu.SetActive(wanted);
        GameOverMenu.SetActive(wanted);
    }

    public void LaunchGame()
    {
        HideAllMenus();
        GameplayUI.SetActive(true);
    }



}
