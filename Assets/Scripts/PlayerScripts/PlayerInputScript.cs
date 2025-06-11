using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    private KeyCode LastKeyPress;
    private PlayerMovementScript m_Script;
    private bool ActiveControl;
    // Start is called before the first frame update
    void Start()
    {
        m_Script = GetComponent<PlayerMovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GAME.MANAGER.CurrentState == State.Gameplay)
        {
            if (Input.GetKeyDown(KeyCode.D)) LastKeyPress = KeyCode.D;
            if (Input.GetKeyDown(KeyCode.Q)) LastKeyPress = KeyCode.Q;
            if (Input.GetKey(LastKeyPress))
            {
                if (LastKeyPress == KeyCode.Q) m_Script.MoveLeft();
                if (LastKeyPress == KeyCode.D) m_Script.MoveRight();

            }
            else
            {
                m_Script.Stop();
            }
        }
       
    }
}
