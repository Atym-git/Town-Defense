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

    private void Start()
    {
        StartCoroutine(TimerWorking());
    }


    public IEnumerator TimerWorking()
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
            _difference = (wheatScript.civilians + wheatScript.warriors) - wheatScript.wheat;
            if (wheatScript.wheat < (wheatScript.civilians + wheatScript.warriors) & wheatScript.warriors >= _difference)
            {
                wheatScript.warriors -= _difference;
            }
            else if (wheatScript.wheat < (wheatScript.civilians + wheatScript.warriors) & (wheatScript.warriors + wheatScript.civilians) >= _difference)
            {
                wheatScript.civilians -= _difference + wheatScript.warriors;
                wheatScript.warriors -= _difference;
            }
            else
            { 
            wheatScript.wheat -= wheatScript.civilians + wheatScript.warriors;
            }
        }
        else
        {
            _image.fillAmount += _imageFillSpeed;
        }
    }
}
