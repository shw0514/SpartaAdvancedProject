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

    public void BuyUnitOne()
    {
        UIManager.instance.gold -= UIManager.instance.priceOfUnitOne;
        GameManager.instance.SpawnUnitOne();
    }

    public void BuyUnitTwo()
    {
        UIManager.instance.gold -= UIManager.instance.priceOfUnitTwo;
        GameManager.instance.SpawnUnitOne();
    }

    public void BuyResourceGetherer()
    {
        UIManager.instance.gold -= UIManager.instance.priceOfResourceGetherer;
        UIManager.instance.ResourceGethererAdded();
    }
}
