using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorBehavior : MonoBehaviour
{
    void OnMouseOver()
    {
        if ((Input.GetMouseButtonDown(0)) && (GetComponent<MeshRenderer>().material.color == Color.green))
        {
            GameObject.Find("Cube").GetComponent<GameBehavior>().oneSecond = 1.1f;
            if (GameObject.Find("Cube").GetComponent<GameBehavior>().count < 999)
            {
                GameObject.Find("Cube").GetComponent<GameBehavior>().count++;
                GameObject.Find("Counter").GetComponent<UnityEngine.UI.Text>().text = "Mutants Wacked: " + GameObject.Find("Cube").GetComponent<GameBehavior>().count.ToString();
            }
        }
    }
}