using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public Transform pfArrow;// , Vector3 targetPosition
    public  void Create(Vector3 spawnPosition)
    {
        Instantiate(pfArrow, spawnPosition, Quaternion.identity);
    }
}
