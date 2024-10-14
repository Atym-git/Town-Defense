using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Wheat_Timer : MonoBehaviour
{
    public int _civilians = 0;
    public int _warriors = 0;
    //[SerializeField] private int _time = 10;
    [SerializeField] private Image _image;
    [SerializeField] private float _imageFillSpeed = 0.1f;
    [SerializeField] public int _wheat = 0;
    [SerializeField] private TextMeshProUGUI _textMeshPro;
    [SerializeField] private TextMeshProUGUI _textMeshPro2;
    [SerializeField] private TextMeshProUGUI _textMeshPro3;
    private float _currTime;



    
    private void Start()
    {
        StartCoroutine(Delay());
    }

    private void WheatTimer()
    {
        if (_image.fillAmount == 1)
        {
            _image.fillAmount = 0;
            _wheat = _wheat + _civilians;
        }
        else
        {
            _image.fillAmount = _image.fillAmount + _imageFillSpeed;
        }
    }


    IEnumerator Delay()
    {
        while (true)
        {
            WheatTimer();
            yield return new WaitForSeconds(0.25f);
        }   
    }


    void Update()
    {
        if (_warriors < 0 || _civilians < 0)
        {
            _warriors = 0;
            _civilians = 0;
        }
        if (_wheat <= 0 & _civilians <= 0)
        {
            // Game Over
            _wheat = 0;
            _civilians = 1;
        }
        //    if (_currTime >= 0)
        //    {
        //        _currTime -= Time.deltaTime;
        //        _image.fillAmount = _currTime / _time;
        //    }

        //    if (_image.fillAmount == 1)
        //    {
        //        _wheat = _wheat + _civilians;
        //        _image.fillAmount = 0;
        //    }
        _textMeshPro.text = _wheat.ToString();
        _textMeshPro2.text = _civilians.ToString();
        _textMeshPro3.text = _warriors.ToString();
    }
    //private void StartTimer()
    //{
    //    _currTime = _time;
    //}
}
