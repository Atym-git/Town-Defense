using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartNewGame : MonoBehaviour
{
    [SerializeField] Button startANewGameButton;
    [SerializeField] Canvas gameCanvas;
    [SerializeField] Canvas menuCanvas;
    [SerializeField] Wheat_Timer wheatScript;
    
    void Start()
    {
        startANewGameButton.onClick.AddListener(StartANewGame);
    }

    public void StartANewGame()
    {
        menuCanvas.gameObject.SetActive(false);
        gameCanvas.gameObject.SetActive(true);
        wheatScript._warriors = 0;
        wheatScript._civilians = 1;
        wheatScript._wheat = 0;
    }
}
