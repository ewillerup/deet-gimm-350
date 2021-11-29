using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject[] wayPoints;
    public float speed = 10;
    public int nextWayPoint = 0;

    private void Start()
    {
        
    }
    void FixedUpdate()
    {
        
        float step = speed * Time.deltaTime;
        if  (nextWayPoint == wayPoints.Length)
        {
            Destroy(gameObject);
        }
        else if (wayPoints.Length != nextWayPoint)
        {
            transform.position = Vector3.MoveTowards(transform.position, wayPoints[nextWayPoint].transform.position, step);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
            nextWayPoint++;
    }
}
