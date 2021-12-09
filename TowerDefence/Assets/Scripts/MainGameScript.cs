using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainGameScript : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject enemy;
    private int fakeSpawnInterval;
    public int spawnInterval;
    public Deathray MyDeathray;
    public int hp;
    private int damage = 1;
    public HealthBar healthBar;
    public GameObject gameOver;

    private Grid grid;

    private void Start()
    {
        Vector3 start = startPoint.transform.position;
        enemy.transform.position = start;
        //Instantiate(enemy);
        Grid grid = new Grid(8, 4, 10f);

        healthBar.SetMaxHealth(hp);
        healthBar.SetHealth(hp);
    }

    public void TakeDamage() {
        hp -= damage;
        healthBar.GetDamaged(damage, hp, healthBar);
        Debug.Log(hp);
    }

    void FixedUpdate()
    {
        if (hp <= 0) {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }

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
