using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI goldText;
    public TextMeshProUGUI unitOnePrice;
    public TextMeshProUGUI unitTwoPrice;
    public TextMeshProUGUI resourceGethererPrice;
    public TextMeshProUGUI UnitOneCount;
    public TextMeshProUGUI UnitTwoCount;
    public TextMeshProUGUI ResourceGethererCount;

    public Animator warningMessageAnimator;
    public Animator gethererWarningAnimator;

    [HideInInspector]
    public int gold;
    [HideInInspector]
    public int priceOfUnitOne;
    [HideInInspector]
    public int priceOfUnitTwo;
    [HideInInspector]
    public int priceOfResourceGetherer;
    [HideInInspector]
    public int unitOneCount;
    [HideInInspector]
    public int unitTwoCount;
    [HideInInspector]
    public int resourceGethererCount;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        priceOfUnitOne = 150;
        priceOfUnitTwo = 250;
        priceOfResourceGetherer = 200;
        unitOneCount = 0;
        unitTwoCount = 0;
        resourceGethererCount = 0;
        gold = 1200;
        unitOnePrice.text = priceOfUnitOne.ToString();
        unitTwoPrice.text = priceOfUnitTwo.ToString();
        resourceGethererPrice.text = priceOfResourceGetherer.ToString();

        InvokeRepeating("AddGold", 0f, 0.3f);
    }

    public void ResourceGethererAdded()
    {
        StartCoroutine("GetheringGold");
    }

    private void Update()
    {
        goldText.text = gold.ToString();
        UnitOneCount.text = unitOneCount.ToString();
        UnitTwoCount.text = unitTwoCount.ToString();
        ResourceGethererCount.text = resourceGethererCount.ToString();
    }

    private void AddGold()
    {
        gold += 1;
    }

    IEnumerator GetheringGold()
    {
        while (true)
        {
            AddGold();
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void InstantiateMineralWarningMessage()
    {
        warningMessageAnimator.SetBool("isWarned", true);
        Invoke("StopAnimation_Mineral", 0.3f);
    }

    public void InstantiateGethererWarningMessage()
    {
        gethererWarningAnimator.SetBool("isConstructed", true);
        Invoke("StopAnimation_Getherer", 0.3f);
    }

    public void StopAnimation_Mineral()
    {
        warningMessageAnimator.SetBool("isWarned", false);
    }

    public void StopAnimation_Getherer()
    {
        gethererWarningAnimator.SetBool("isConstructed", false);
    }
}
