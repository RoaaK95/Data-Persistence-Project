using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Text playerDataText;
   
    private void Start()
    {
        playerDataText.text = "Best Score: " + GameManager.instance.playerName + " : " + GameManager.instance.bestScore;
        GameManager.instance.LoadPlayerData();
    }
    public void StartNew()
    {
        
        SceneManager.LoadScene(1);
        SetName(GameManager.instance.playerName);

        
    }

    public void Exit()
    {
       
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
       Application.Quit();
#endif
    }

    public void SetName(string input)
    {
        GameManager.instance.playerName = input;
    }

    public void DisplayName()
    {
        inputField.text = GameManager.instance.playerName;
    }

   







}
