using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public Text playertext;
    public Text Best;
    
    // Start is called before the first frame update
    void Start()
    {
        Best.text = "Best Score: " + MyMainManager.Instance.BestPlayer + " : " + MyMainManager.Instance.BestScore;
        if (MyMainManager.Instance!=null)
        {
            ApplyName(MyMainManager.Instance.PlayerName);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ApplyName(string name)
    {
        playertext.text = "Player: " + name;
    }
}
