using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WaveOfEnemies : MonoBehaviour
{
    [SerializeField] int enemiesStartAmount;
    [SerializeField] TextMeshProUGUI showingAmountOfTime;
    [SerializeField] int currentAmountOfTimeToWave;
    private int amountOfTimeToWave;


    void Start()
    {
        amountOfTimeToWave = currentAmountOfTimeToWave;
        StartCoroutine(TimeUntilNextWave());
    }

    IEnumerator TimeUntilNextWave()
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
static void WaveStart()
    {

    }

    void Update()
    {
        showingAmountOfTime.text = currentAmountOfTimeToWave.ToString();
    }
}
