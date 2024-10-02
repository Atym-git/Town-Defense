using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HireaWarrior : MonoBehaviour
{
    [SerializeField] Button _button;
    [SerializeField] TextMeshProUGUI _textMeshPro;
    Wheat_Timer _wheatScript;

    void Start()
    {
        _wheatScript = FindObjectOfType<Wheat_Timer>();
        _button.onClick.AddListener(HireWarrior);
    }


    void Update()
    {

    }

    private void HireWarrior()
    {
        if (_wheatScript._wheat != 0)
        {
            _wheatScript._wheat--;
            _wheatScript._warriors++;

        }
        else
        {
            _textMeshPro.enabled = true;
            StartCoroutine(Delay());
            _textMeshPro.enabled = false;
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1f);
    }
}
