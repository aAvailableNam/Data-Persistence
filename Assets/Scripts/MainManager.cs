using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public string playerName;
    public string BestPlayerName;
    public static int highscore = 0;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadName();

    }

    [System.Serializable]
    class SaveData
    {
        public string BestPlayerName;
        public int highscore;
    }

    public void SaveName()
    {
        SaveData data = new SaveData();

        data.BestPlayerName = BestPlayerName;
        data.highscore = highscore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            BestPlayerName = data.BestPlayerName;
            highscore = data.highscore;
        }
    }
}
