using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName;
    public string bestPlayerName;
    public int bestScore = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadData();
    }

    public void SetBestScore(int newBestScore)
    {
        bestPlayerName = playerName;
        bestScore = newBestScore;
        SaveData();
    }

    [System.Serializable]
    class bestScoreData
    {
        public string bestPlayerName;
        public int bestScore;
    }

    public void SaveData()
    {
        bestScoreData data = new bestScoreData();
        data.bestPlayerName = bestPlayerName;
        data.bestScore = bestScore;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            bestScoreData data = JsonUtility.FromJson<bestScoreData>(json);
            bestPlayerName = data.bestPlayerName;
            bestScore = data.bestScore;
        }
    }
}
