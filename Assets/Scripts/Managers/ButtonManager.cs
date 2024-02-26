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
            uiManager.InstantiateGathererWarningMessage();
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

    public void BuyResourceGatherer()
    {
        if (uiManager.gold >= uiManager.priceOfResourceGatherer)   
        {
            if (uiManager.resourceGathererCount < 5)
            {
                uiManager.gold -= uiManager.priceOfResourceGatherer;
                uiManager.ResourceGathererAdded();
                uiManager.resourceGathererCount++;
            }
            else
            {
                uiManager.InstantiateGathererWarningMessage();
            }
        }  
        else
        {
            uiManager.InstantiateMineralWarningMessage();
        }
    }
}
