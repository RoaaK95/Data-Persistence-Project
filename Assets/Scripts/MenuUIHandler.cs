using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public void PlayerName()
    {

    }
     public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
       Application.Quit();
#endif
    }

}
