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
    [SerializeField] WaveOfEnemies waveOfEnemiesScript;
    [SerializeField] WheatContibution contibutionScript;
    [SerializeField] HireaFermer hireaFermerScript;
    [SerializeField] HireaWarrior hireaWarriorScript;

    void Start()
    {
        startANewGameButton.onClick.AddListener(StartANewGame);
    }

    void StartANewGame()
    {
        menuCanvas.gameObject.SetActive(false);
        gameCanvas.gameObject.SetActive(true);
        wheatScript._warriors = 0;
        wheatScript._civilians = 1;
        wheatScript._wheat = 0;
        //waveOfEnemiesScript.currentAmountOfTimeToWave = waveOfEnemiesScript.startingAmountOfTimeToWave;
        //waveOfEnemiesScript.enemiesCurrAmount = waveOfEnemiesScript.enemiesStartAmount;
        //wheatScript._image.fillAmount = 0;
        //hireaFermerScript.imageFarmerTimer.fillAmount = 0;
        //hireaWarriorScript.imageWarriorTimer.fillAmount = 0;
        StartCoroutine(wheatScript.WheatGive());
        StartCoroutine(contibutionScript.TimerWorking());
    }
}
