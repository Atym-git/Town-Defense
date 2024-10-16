using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverRestart : MonoBehaviour
{
    [SerializeField] Canvas mainMenuCanvas;
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Button backToMainMenuButton;

    void Start()
    {
        backToMainMenuButton.onClick.AddListener(Restart);   
    }
   
    void Restart()
    {
        mainMenuCanvas.gameObject.SetActive(true);
        gameOverCanvas.gameObject.SetActive(false);
    }

}
