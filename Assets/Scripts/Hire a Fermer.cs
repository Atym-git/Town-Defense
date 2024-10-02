using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HireaFermer : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TextMeshProUGUI _textmeshpro;
    Wheat_Timer _wheatScript;
    //[SerializeField] public int _civilians;


    void Start()
    {
        _button.onClick.AddListener(Hire_Farmer);
        _wheatScript = FindFirstObjectByType<Wheat_Timer>();

    }

    private void Hire_Farmer()
    {
        if (_wheatScript._wheat != 0)
        {
            _wheatScript._wheat--;
            _wheatScript._civilians++;
        }
        else
        {
            _textmeshpro.enabled = true;
            StartCoroutine(Delay());
            _textmeshpro.enabled = false;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.75f);
    }

    void Update()
    {
        
    }
}
