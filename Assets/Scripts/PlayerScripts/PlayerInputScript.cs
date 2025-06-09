using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    private PlayerMovementScript m_Script;
    // Start is called before the first frame update
    void Start()
    {
        m_Script = GetComponent<PlayerMovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            m_Script.MoveLeft();
        }

        else if(Input.GetKey(KeyCode.D))
        {
            m_Script.MoveRight();
        }

        else
        {
            m_Script.Stop();
        }
    }
}
