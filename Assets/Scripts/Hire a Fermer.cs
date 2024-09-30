using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HireaFermer : MonoBehaviour
{
    [SerializeField] private Button _button;
    Wheat_Timer _wheat;
    //[SerializeField] public int _civilians;
    

    void Start()
    {
        _button.onClick.AddListener(Hire_Farmer);
        _wheat = FindFirstObjectByType<Wheat_Timer>();
        
    }

    private void Hire_Farmer()
    {
        if (_wheat._wheat != 0)
        {
            _wheat._wheat = _wheat._wheat--;
            _wheat._civilians = _wheat._civilians++;
        }
    }


    void Update()
    {
        
    }
}
