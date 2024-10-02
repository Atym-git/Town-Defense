using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WheatContibution : MonoBehaviour
{
    [SerializeField] private Wheat_Timer _wheatScript;
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private Image _image;
    private int _difference;
    void Awake()
    {
        
        StartCoroutine(TimerWorking());
    }
    IEnumerator TimerWorking()
    {
        while (true)
        {
        yield return new WaitForSeconds(1);
        WheatContrib();
        }
    }
    
    private void WheatContrib()
    {
        if (_image.fillAmount == 1)
        {
            _image.fillAmount = 0;
            _difference = (_wheatScript._civilians + _wheatScript._warriors) - _wheatScript._wheat;
            if (_wheatScript._wheat < (_wheatScript._civilians + _wheatScript._warriors) & _wheatScript._warriors >= _difference)
            {
                _wheatScript._warriors -= _difference;
            }
            else if (_wheatScript._wheat < (_wheatScript._civilians + _wheatScript._warriors) & (_wheatScript._warriors + _wheatScript._civilians) >= _difference)
            {
                _wheatScript._warriors -= _difference;
                _wheatScript._civilians += _wheatScript._warriors;
            }
            else if (_wheatScript._wheat < (_wheatScript._civilians + _wheatScript._warriors) & (_wheatScript._warriors + _wheatScript._civilians) < _difference)
            {
                //Game Over
                _textMeshPro.enabled = true;
                StartCoroutine(Delay());
                //Come back button don't know how to make yet
            }
            else
            { 
            _wheatScript._wheat -= _wheatScript._civilians + _wheatScript._warriors;
            }
        }
        else
        {
            _image.fillAmount += 0.1f;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2);
    } 

    void Update()
    {
        
    }
}
