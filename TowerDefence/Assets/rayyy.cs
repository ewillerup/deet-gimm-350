using UnityEngine;
//using Vuforia;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class rayyy : MonoBehaviour
{

    private GameObject focusObj = null;
    private float focusx;
    private float focusy;
    private float focusz;


    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            focusObj = null;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))

            {
                focusObj = hit.transform.gameObject;
            }
        }


        if (focusObj && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            focusx = Input.GetTouch(0).deltaPosition.x / 500;
            focusz = 0;
            focusy = Input.GetTouch(0).deltaPosition.y / 500;

            Vector3 pos = new Vector3(focusx, focusz, focusy);
            focusObj.transform.position += pos;


        }
        if (focusObj && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            focusObj = null;
        }
        Vector3 mousePos = Input.mousePosition;
        Debug.DrawRay(transform.position, new Vector3 (0, 0, 50), Color.green);
    }
}