using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject enemy;
    private int fakeSpawnInterval;
    public int spawnInterval;
    public Deathray MyDeathray;

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
        if (spawnInterval >= 8)
        {
            spawnInterval = 30 - MyDeathray.IntScore;
        }
       
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
