using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RayCast : MonoBehaviour
{
    public GameObject optionsPanel;
    public GameObject mainPanel;
    public LayerMask layer;
    public RaycastHit hit;

    private void Update() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Debug.DrawRay(ray.origin, ray.direction * 1000, Color.red);
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit, 500, layer)) {
            Debug.Log(hit.transform.gameObject.name);
        }
    }
}
