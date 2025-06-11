using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVENTS
{
    static void LogEventInConsole(string message)
    {
        Debug.Log(message);
    }

    public static event Action OnInitialization;
    public static void InvokeInitialization() { LogEventInConsole("Initialization"); OnInitialization?.Invoke();}

    public static event Action OnGameStart;
    public static void InvokeGameStart() { LogEventInConsole("GameStart"); OnGameStart?.Invoke(); }

    public static event Action OnGameEnd;
    public static void InvokeGameEnd() { LogEventInConsole("GameEnd"); OnGameEnd?.Invoke(); }   


}
