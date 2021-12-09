using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject[] wayPoints;
    public float speed = 10;
    public int nextWayPoint = 0;
    public GameObject gameController;

    void Awake() {
        speed += Random.Range(-2, 2);
        Rigidbody m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.AddForce(transform.up * Random.Range(0, 1000));
    }
    
    void FixedUpdate()
    {
        
        float step = speed * Time.deltaTime;
        if  (nextWayPoint == wayPoints.Length)
        {
            gameController = GameObject.Find("GameController");
            gameController.BroadcastMessage("TakeDamage");
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
