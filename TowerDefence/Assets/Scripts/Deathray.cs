using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathray : MonoBehaviour
{
    public RaycastHit hit;
    public Vector3 forward;
    public int count = 0;
    public bool beeHit = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.blue);

        if (Physics.Raycast(transform.position, (forward), out hit))
        {
            if (gameObject.tag == "Raycast")
            {
                if (hit.collider.gameObject.tag == "Bee")
                {
                    hit.transform.SendMessage("HitByRay");
                    


                    Destroy(hit.collider.gameObject);
                   

                   
                }
            }

        }
    }
}