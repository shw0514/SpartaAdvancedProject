using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject shopButton;

    public void OpenShop()
    {
        shopPanel.SetActive(true);
        shopButton.SetActive(false);
    }

    public void CloseShop()
    {
        shopPanel.SetActive(false);
        shopButton.SetActive(true);
    }
}
