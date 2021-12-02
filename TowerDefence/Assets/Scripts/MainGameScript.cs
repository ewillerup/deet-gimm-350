using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject enemy;
    private int fakeSpawnInterval;
    public int spawnInterval;

    private Grid grid;

    private void Start()
    {
        Vector3 start = startPoint.transform.position;
        enemy.transform.position = start;
        //Instantiate(enemy);
        Grid grid = new Grid(8, 4, 10f);
    }
    void FixedUpdate()
    {
        if (fakeSpawnInterval > spawnInterval)
        {
            Instantiate(enemy);
            fakeSpawnInterval = 0;
        }
        else
        {
            fakeSpawnInterval++;
        }
    }
}
