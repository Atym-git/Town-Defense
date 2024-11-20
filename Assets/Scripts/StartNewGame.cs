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
    [SerializeField] CoroutineRunner CoroutineRunnerScript;

    void Start()
    {
        startANewGameButton.onClick.AddListener(StartANewGame);
    }

    void StartANewGame()
    {
        wheatScript.warriors = 0;
        wheatScript.civilians = 1;
        wheatScript.wheat = 0;
        waveOfEnemiesScript.enemiesCurrAmount = waveOfEnemiesScript.enemiesStartAmount;
        wheatScript.image.fillAmount = 0;
        hireaFermerScript.imageFarmerTimer.fillAmount = 0;
        hireaWarriorScript.imageWarriorTimer.fillAmount = 0;
        contibutionScript.wheatContributionTimer.fillAmount = 0;
        CoroutineRunnerScript.StartCoroutines();
        menuCanvas.gameObject.SetActive(false);
        gameCanvas.gameObject.SetActive(true);


    }
}
