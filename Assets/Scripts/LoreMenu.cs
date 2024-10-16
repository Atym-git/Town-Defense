using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoreMenu : MonoBehaviour
{
    [SerializeField] Canvas mainMenuCanvas;
    [SerializeField] Canvas loreCanvas;
    [SerializeField] Button loreButton;

    void Start()
    {
        loreButton.onClick.AddListener(GoToLoreMenu);
    }

    void GoToLoreMenu()
    {
        loreCanvas.gameObject.SetActive(true);
        mainMenuCanvas.gameObject.SetActive(false);
    }



}
