using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryComeBack : MonoBehaviour
{
    [SerializeField] Canvas mainMenuCanvas;
    [SerializeField] Canvas victoryCanvas;
    [SerializeField] Button backToMainMenu;

    void Start()
    {
        backToMainMenu.onClick.AddListener(BackToMainMenu);
    }

    void BackToMainMenu()
    {
        victoryCanvas.gameObject.SetActive(false);
        mainMenuCanvas.gameObject.SetActive(true);
    }



}
