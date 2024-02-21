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
        if (UIManager.instance.gold >= UIManager.instance.priceOfUnitOne)
        {
            UIManager.instance.gold -= UIManager.instance.priceOfUnitOne;
            GameManager.instance.SpawnUnitOne();
        }
        else
        {
            UIManager.instance.InstantiateWarningMessage();
        }
        
    }

    public void BuyUnitTwo()
    {
        if (UIManager.instance.gold >= UIManager.instance.priceOfUnitTwo)
        {
            UIManager.instance.gold -= UIManager.instance.priceOfUnitTwo;
            GameManager.instance.SpawnUnitTwo();
        }
        else
        {
            UIManager.instance.InstantiateWarningMessage();
        }
            
    }

    public void BuyResourceGetherer()
    {
        if (UIManager.instance.gold >= UIManager.instance.priceOfResourceGetherer)
        {
            UIManager.instance.gold -= UIManager.instance.priceOfResourceGetherer;
            UIManager.instance.ResourceGethererAdded();
        }
        else
        {
            UIManager.instance.InstantiateWarningMessage();
        }
    }
}
