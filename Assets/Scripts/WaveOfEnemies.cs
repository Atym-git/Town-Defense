using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WaveOfEnemies : MonoBehaviour
{
    [SerializeField] int enemiesStartAmount;
    [SerializeField] TextMeshProUGUI showingAmountOfTime;
    [SerializeField] TextMeshProUGUI showingAmountOfEnemies;
    [SerializeField] int currentAmountOfTimeToWave;
    private int amountOfTimeToWave;
    private int enemiesCurrAmount = 0;
    [SerializeField] Wheat_Timer wheatScript;

    void Start()
    {
        enemiesCurrAmount = enemiesStartAmount;
        amountOfTimeToWave = currentAmountOfTimeToWave;
        StartCoroutine(TimeUntilNextWave());
    }

    private IEnumerator TimeUntilNextWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            currentAmountOfTimeToWave--;
            if (currentAmountOfTimeToWave <= 0)
            {
                currentAmountOfTimeToWave = amountOfTimeToWave;
                WaveStart();
            }
        }
    }
    void WaveStart()
    {
        if (enemiesCurrAmount <= wheatScript._warriors)
        {
            wheatScript._warriors -= enemiesCurrAmount;
        }
        else /*(enemiesCurrAmount <= wheatScript._warriors + wheatScript._civilians / 3)*/
        {   
            wheatScript._civilians -= enemiesCurrAmount * 3 - wheatScript._warriors * 3;
            wheatScript._warriors -= enemiesCurrAmount;
            Debug.Log("Test");
        }


        enemiesCurrAmount++;
    }

    void Update()
    {
        showingAmountOfTime.text = currentAmountOfTimeToWave.ToString() + " seconds";
        showingAmountOfEnemies.text = enemiesCurrAmount.ToString() + " Enemies will appear in";
    }
}
