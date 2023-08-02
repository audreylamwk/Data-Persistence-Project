using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class StartMenuUI : MonoBehaviour
{
    public InputField iField;
    string player_name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void NameEntered()
    {
        player_name = iField.text;
        MyMainManager.Instance.PlayerName = player_name;

    }


}
