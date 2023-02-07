using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float MinX;
    public float MinY;
    public float MaxX;
    public float MaxY;
    public int maxvalue = 15;
    public int currentvalue;
    private void Awake()
    {
        currentvalue = 0;
        SpawnEnemyOnMap();
    }

    private void SpawnEnemyOnMap()
    {
        if (currentvalue < maxvalue)
        {
            float xPos = Random.Range(MinX, MaxX);
            float yPos = Random.Range(MinY, MaxY);
            Vector3 spawnPos = new Vector3(xPos, yPos, 0);
            Instantiate(enemyPrefabs[Random.Range(0, 2)], spawnPos, Quaternion.identity);
        }
        else { }
    }
    private void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        currentvalue = enemies.Length;
        if (currentvalue < maxvalue)
        {
            SpawnEnemyOnMap();
        }
        else { }
    }
}
