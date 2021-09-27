using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject square;
    public Text[] buttonList;
    string turn = "o";
    
    public void SquareClicked(int squareNumber) {
        Debug.Log("i shitted");
        if (turn == "o") {
            // set matrix number
            //squareNumber.setmaterial("o");
            turn = "x";
        } else if (turn == "x") {
            //squareNumber.setmaterial("x");
            turn = "o";
        }
    }

    void CheckForWin() {
        // if the matrix has 3 in a row
    }


    void Update()
    {
        
    }
}
