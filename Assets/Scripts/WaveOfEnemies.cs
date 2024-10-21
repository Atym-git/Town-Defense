using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WaveOfEnemies : MonoBehaviour
{
    [SerializeField] public int enemiesStartAmount;
    [SerializeField] TextMeshProUGUI showingAmountOfTime;
    [SerializeField] TextMeshProUGUI showingAmountOfEnemies;
    [SerializeField] public int currentAmountOfTimeToWave;
    public int startingAmountOfTimeToWave;
    public int enemiesCurrAmount = 0;
    [SerializeField] Wheat_Timer wheatScript;

    void Start()
    {
        enemiesCurrAmount = enemiesStartAmount;
        startingAmountOfTimeToWave = currentAmountOfTimeToWave;
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
                currentAmountOfTimeToWave = startingAmountOfTimeToWave;
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
        else
        {   
            wheatScript._civilians -= enemiesCurrAmount * 3 - wheatScript._warriors * 3;
            wheatScript._warriors -= enemiesCurrAmount;
        }

        if (startingAmountOfTimeToWave <= 20)
        {
            startingAmountOfTimeToWave = 20;
            enemiesCurrAmount += 2;
        }
        else
        {
            startingAmountOfTimeToWave -= 2;
            enemiesCurrAmount++;
        }
    }

    void Update()
    {
        showingAmountOfTime.text = currentAmountOfTimeToWave.ToString() + " seconds";
        showingAmountOfEnemies.text = enemiesCurrAmount.ToString() + " Enemies will appear in";
    }
}
