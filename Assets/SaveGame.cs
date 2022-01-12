using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveGame : MonoBehaviour
{

    public static SaveGame Instance;
    public SaveData activeSave;
    public int best_score;

    public void Awake()
    {
        Instance = this;

        DontDestroyOnLoad(this);
        LoadScore();
    }

    [System.Serializable]
    public class SaveData
    {
        public int best_score;
    }

    public void SaveScore(int best_score)
    {
        SaveData data = new SaveData();
        data.best_score = best_score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

           activeSave.best_score = data.best_score;
        }
    }

}
