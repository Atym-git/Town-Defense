using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Farmer_Timer : MonoBehaviour
{
    [SerializeField] public Image imageTimer;
    [SerializeField] float _timerFillSpeed;
    [SerializeField] Wheat_Timer wheatScript;

    //private void Start()
    //{
    //    StartCoroutine(FarmerTimer());
    //}

    //private void WheatTimer()
    //{
    //    if (imageTimer.fillAmount == 1)
    //    {
    //        wheatScript._civilians++;
    //    }
    //    else
    //    {
    //        imageTimer.fillAmount += _timerFillSpeed;
    //    }
    //}


    public IEnumerator FarmerTimer()
    {
        while (imageTimer.fillAmount < 1)
         {
            imageTimer.fillAmount += _timerFillSpeed;
            yield return new WaitForSeconds(0.25f);
                if (imageTimer.fillAmount == 1)
                {
                imageTimer.fillAmount = 0;
                wheatScript._civilians++;
                yield break;
                }
         }
    }
}
