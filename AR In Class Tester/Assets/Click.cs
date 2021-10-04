using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

    void OnClick() {
        transform.Translate(Vector3.up * 0.3f);
    }
}
