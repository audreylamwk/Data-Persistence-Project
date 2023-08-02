using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public Text playertext;
    // Start is called before the first frame update
    void Start()
    {
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
