using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorBehaviour : MonoBehaviour
{
    void OnMouseOver()
    {
        if ((Input.GetMouseButtonDown(0)) && (GetComponent<MeshRenderer>().material.color == Color.green))
        {
            GameObject.Find("Cube").GetComponent<GameBehaviour>().oneSecond = 1.1f;
            if (GameObject.Find("Cube").GetComponent<GameBehaviour>().count < 999)
            {
                GameObject.Find("Cube").GetComponent<GameBehaviour>().count++;
                GameObject.Find("Counter").GetComponent<UnityEngine.UI.Text>().text = "Mutants Wacked: " + GameObject.Find("Cube").GetComponent<GameBehaviour>().count.ToString();
            }
        }
    }
}