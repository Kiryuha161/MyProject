using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startGameButton;
    [SerializeField] private Button loadGameButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button exitButton;

    // Start is called before the first frame update
    void Start()
    {
        startGameButton = GameObject.Find("Start game button").GetComponent<Button>();
        loadGameButton = GameObject.Find("Load game button").GetComponent<Button>();
        settingsButton = GameObject.Find("Settings button").GetComponent<Button>();
        exitButton = GameObject.Find("Exit button").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
