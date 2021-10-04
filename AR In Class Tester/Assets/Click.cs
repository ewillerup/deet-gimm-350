using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public int squareID;
    public GameObject GameController;

    void OnClick() {
        transform.Translate(Vector3.left * 0.3f);
    }
}
