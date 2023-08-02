using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MyMainManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static MyMainManager Instance;
    public string PlayerName;
    public int Score;
    public string BestPlayer;
    public int BestScore;
    static public int maximum = -100000;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (Instance!=null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadPlayer();
    }

    [System.Serializable]
    class SaveData
    {
        public string PlayerName;
        public int Score;
    }

    public void SavePlayer()
    {
        SaveData data = new SaveData();
        maximum = Mathf.Max(Score, maximum);
        if (Score == maximum)
        {
            data.PlayerName = PlayerName;
            data.Score = Score;
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
        }

       
    }

    public void LoadPlayer()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            BestPlayer = data.PlayerName;
            BestScore = data.Score;
        }
        
    
    }

}
