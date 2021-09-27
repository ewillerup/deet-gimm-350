using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public int squareID;
    public GameObject GameController;

    void OnClick() {
        GameController gc = GameController.GetComponent<GameController>();
        gc.SquareClicked(squareID);
    }
}
