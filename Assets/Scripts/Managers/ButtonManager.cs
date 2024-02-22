using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    UIManager uiManager;
    public GameObject shopPanel;
    public GameObject shopButton;

    private void Start()
    {
        uiManager = UIManager.instance;
    }
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
        if (uiManager.gold >= uiManager.priceOfUnitOne)
        {
            uiManager.gold -= uiManager.priceOfUnitOne;
            GameManager.instance.SpawnUnitOne();
            uiManager.unitOneCount++;
                
        }
        else
        {
            uiManager.InstantiateGethererWarningMessage();
        }
        
    }

    public void BuyUnitTwo()
    {
        if (uiManager.gold >= uiManager.priceOfUnitTwo)
        {
            uiManager.gold -= uiManager.priceOfUnitTwo;
            GameManager.instance.SpawnUnitTwo();
            uiManager.unitTwoCount++;
        }
        else
        {
            uiManager.InstantiateMineralWarningMessage();
        }
            
    }

    public void BuyResourceGetherer()
    {
        if (uiManager.gold >= uiManager.priceOfResourceGetherer)   
        {
            if (uiManager.resourceGethererCount < 5)
            {
                uiManager.gold -= uiManager.priceOfResourceGetherer;
                uiManager.ResourceGethererAdded();
                uiManager.resourceGethererCount++;
            }
            else
            {
                uiManager.InstantiateGethererWarningMessage();
            }
        }  
        else
        {
            uiManager.InstantiateMineralWarningMessage();
        }
    }
}
