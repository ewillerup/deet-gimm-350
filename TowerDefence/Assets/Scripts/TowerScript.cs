using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{
    private Vector3 projectileShootFromPosition;
    public GameObject pfArrow;

    public Camera worldCamera { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        projectileShootFromPosition = transform.Find("ProjectileShootFromPosition").position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            pfArrow.GetComponent<ArrowScript>().Create(GetMouseWorldPosition());
        }
    }
    public Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec;
    }
    public static Vector3 GetMouseWorldPositionWithZ()
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
    }
    //public static Vector3 GetMouseWorldPositionWithZ()
    //{
    //    return GetMouseWorldPositionWithZ(Input.mousePosition, worldCamera);
    //}
    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }
}
