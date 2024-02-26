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
    public TextMeshProUGUI resourceGathererPrice;
    public TextMeshProUGUI UnitOneCount;
    public TextMeshProUGUI UnitTwoCount;
    public TextMeshProUGUI ResourceGathererCount;

    public Animator warningMessageAnimator;
    public Animator gethererWarningAnimator;

    [HideInInspector]
    public int gold;
    [HideInInspector]
    public int priceOfUnitOne;
    [HideInInspector]
    public int priceOfUnitTwo;
    [HideInInspector]
    public int priceOfResourceGatherer;
    [HideInInspector]
    public int unitOneCount;
    [HideInInspector]
    public int unitTwoCount;
    [HideInInspector]
    public int resourceGathererCount;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        priceOfUnitOne = 150;
        priceOfUnitTwo = 250;
        priceOfResourceGatherer = 800;
        unitOneCount = 0;
        unitTwoCount = 0;
        resourceGathererCount = 0;
        gold = 1200;
        unitOnePrice.text = priceOfUnitOne.ToString();
        unitTwoPrice.text = priceOfUnitTwo.ToString();
        resourceGathererPrice.text = priceOfResourceGatherer.ToString();

        InvokeRepeating("AddGold", 0f, 0.3f);
    }

    public void ResourceGathererAdded()
    {
        StartCoroutine("GatheringGold");
    }

    private void Update()
    {
        goldText.text = gold.ToString();
        UnitOneCount.text = unitOneCount.ToString();
        UnitTwoCount.text = unitTwoCount.ToString();
        resourceGathererPrice.text = priceOfResourceGatherer.ToString();
    }

    private void AddGold()
    {
        gold += 1;
    }

    IEnumerator GatheringGold()
    {
        while (true)
        {
            AddGold();
            yield return new WaitForSeconds(0.2f);
        }
    }

    public void InstantiateMineralWarningMessage()
    {
        warningMessageAnimator.SetBool("isWarned", true);
        Invoke("StopAnimation_Mineral", 0.3f);
    }

    public void InstantiateGathererWarningMessage()
    {
        gethererWarningAnimator.SetBool("isConstructed", true);
        Invoke("StopAnimation_Getherer", 0.3f);
    }

    public void StopAnimation_Mineral()
    {
        warningMessageAnimator.SetBool("isWarned", false);
    }

    public void StopAnimation_Gatherer()
    {
        gethererWarningAnimator.SetBool("isConstructed", false);
    }
}
