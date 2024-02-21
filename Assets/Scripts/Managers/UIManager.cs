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

    [HideInInspector]
    public int gold;
    public int priceOfUnitOne = 150;
    public int priceOfUnitTwo = 250;
    public int priceOfResourceGetherer = 400;

    public float resourceGetherdelay;

    public int resourceGethererCount;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        resourceGetherdelay = 0;
        resourceGethererCount = 0;
        gold = 1200;
        unitOnePrice.text = priceOfUnitOne.ToString();
        unitTwoPrice.text = priceOfUnitTwo.ToString();
        resourceGethererPrice.text = priceOfResourceGetherer.ToString();

        InvokeRepeating("AddGold", 0f, 0.4f);
    }

    public void ResourceGethererAdded()
    {
        StartCoroutine("GetheringGold");
    }

    private void Update()
    {
        goldText.text = gold.ToString();
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
            yield return new WaitForSeconds(0.4f);
        }
    }
}
