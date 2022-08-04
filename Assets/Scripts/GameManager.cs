using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public string playerName;
    public int bestScore;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
         
        instance = this;
        LoadPlayerData();
        DontDestroyOnLoad(gameObject);
        
    }

    [Serializable]
    class SaveData
    {
        public string playername;
        public int bestScore;
    }

    public void SavePlayerData()
    {
        SaveData data = new SaveData();
        data.playername = playerName;
        data.bestScore = bestScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/SaveFile.json" ,json);
    }
    public void LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/SaveFile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            playerName = data.playername;
            bestScore=data.bestScore;
            
        }
    }


}
