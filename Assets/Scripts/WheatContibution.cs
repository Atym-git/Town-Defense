using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WheatContibution : MonoBehaviour
{
    [SerializeField] private Wheat_Timer wheatScript;
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private Image _image;
    [SerializeField] private float _imageFillSpeed;
    private int _difference;
    private int amountOfPeople;

    void Start()
    {
        StartCoroutine(TimerWorking());
    }
    IEnumerator TimerWorking()
    {
        while (true)
        {
        yield return new WaitForSeconds(0.5f);
        WheatContrib();
        }
    }
    
    private void WheatContrib()
    {
        if (_image.fillAmount == 1)
        {
            _image.fillAmount = 0;
            _difference = (wheatScript._civilians + wheatScript._warriors) - wheatScript._wheat;
            if (wheatScript._wheat < (wheatScript._civilians + wheatScript._warriors) & wheatScript._warriors >= _difference)
            {
                wheatScript._warriors -= _difference;
            }
            else if (wheatScript._wheat < (wheatScript._civilians + wheatScript._warriors) & (wheatScript._warriors + wheatScript._civilians) >= _difference)
            {
                wheatScript._civilians -= _difference + wheatScript._warriors;
                wheatScript._warriors -= _difference;
            }
            else
            { 
            wheatScript._wheat -= wheatScript._civilians + wheatScript._warriors;
            }
        }
        else
        {
            _image.fillAmount += _imageFillSpeed;
        }
    }
}
