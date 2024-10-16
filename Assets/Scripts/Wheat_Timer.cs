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
    [SerializeField] private Canvas gameOverCanvas;
    [SerializeField] private Canvas gameCanvas;
    [SerializeField] private Canvas victoryCanvas;
    [SerializeField] private TextMeshProUGUI showingContributionOfWheat;
    private int amountOfPeopleTotal = 0;

    private float _currTime;



    
    private void Start()
    {
        StartCoroutine(WheatGive());
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


    IEnumerator WheatGive()
    {
        while (true)
        {
            WheatTimer();
            yield return new WaitForSeconds(0.5f);
        }   
    }

    void Update()
    {
        if (_warriors < 0)
        {
            _warriors = 0;
        }
        if (_civilians < 0)
        {
            _civilians = 0;
        }
        if (_wheat <= 0 & _civilians <= 0)
        {
            gameCanvas.gameObject.SetActive(false);
            gameOverCanvas.gameObject.SetActive(true);

        }
        if (_civilians >= 50 & _wheat >= 100)
        {
            victoryCanvas.gameObject.SetActive(true);
            gameCanvas.gameObject.SetActive(false);
        }
        amountOfPeopleTotal = _civilians + _warriors;
        showingContributionOfWheat.text = amountOfPeopleTotal.ToString() + " " + "wheat will contribute in";
        _textMeshPro.text = _wheat.ToString();
        _textMeshPro2.text = _civilians.ToString();
        _textMeshPro3.text = _warriors.ToString();
    }
}
