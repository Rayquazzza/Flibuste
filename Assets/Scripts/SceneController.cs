using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] Animator transitionAnim;
    public static SceneController instance;

    private void Awake()
    {
        instance = this;    
    }
    public IEnumerator LoadLevel()
    {      
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1);
        transitionAnim.SetTrigger("Start");
    }
}
