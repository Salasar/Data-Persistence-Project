using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistanceManager : MonoBehaviour {
    public static string currentNickname;
    public static string bestScoreNickname;
    public static int bestScore = 0;
    public static PersistanceManager instance;

    private void Awake() {
        if (instance != null) {
            Destroy(gameObject);
        }
        else 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            LoadBestScore();
        }
    }

    public void SaveBestScore() {
        SaveData saveData = new SaveData();
        saveData.nickname = bestScoreNickname;
        saveData.bestScore = bestScore;

        string json = JsonUtility.ToJson(saveData);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBestScore() {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScore = data.bestScore;
            bestScoreNickname = data.nickname;
        }
    }

    [System.Serializable]
    class SaveData {
        public string nickname;
        public int bestScore;
    }
}