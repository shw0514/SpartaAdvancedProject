using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject unitOne;
    public GameObject unitTwo;

    public GameObject AllieSpawnPoint;
    public GameObject EnemySpawnPoint;

    public Transform Enemy { get; private set; }
    [SerializeField] private string enemyTag = "Enemy";

    private void Awake()
    {
        instance = this;
        Enemy = GameObject.FindGameObjectWithTag(enemyTag).transform;
    }

    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    public void SpawnUnitOne()
    {
        StartCoroutine("UnitOne");
    }

    IEnumerator UnitOne()
    {
        while (true)
        {
            unitOne.GetComponent<SpriteRenderer>().color = new Color(100 / 255f, 100 / 255f, 255 / 255f, 255 / 255f);
            unitOne.tag = "Player";
            Instantiate(unitOne, AllieSpawnPoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(7);
        }    
    }

    public void SpawnUnitTwo()
    {
        StartCoroutine("UnitTwo");
    }

    IEnumerator UnitTwo()
    {
        while (true)
        {
            unitTwo.GetComponent<SpriteRenderer>().color = new Color(100 / 255f, 100 / 255f, 255 / 255f, 255 / 255f);
            unitTwo.tag = "Player";
            Instantiate(unitTwo, AllieSpawnPoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(8);
        }
    }
}
