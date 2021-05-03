using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    GameObject[,] viruses = new GameObject[5, 5];
    Color initialColor;
    int randI, randJ;

    public float oneSecond;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        viruses[0, 0] = GameObject.Find("coronavirus (0)(0)");
        viruses[1, 0] = GameObject.Find("coronavirus (1)(0)");
        viruses[2, 0] = GameObject.Find("coronavirus (2)(0)");
        viruses[3, 0] = GameObject.Find("coronavirus (3)(0)");
        viruses[4, 0] = GameObject.Find("coronavirus (4)(0)");
        viruses[0, 1] = GameObject.Find("coronavirus (0)(1)");
        viruses[1, 1] = GameObject.Find("coronavirus (1)(1)");
        viruses[2, 1] = GameObject.Find("coronavirus (2)(1)");
        viruses[3, 1] = GameObject.Find("coronavirus (3)(1)");
        viruses[4, 1] = GameObject.Find("coronavirus (4)(1)");
        viruses[0, 2] = GameObject.Find("coronavirus (0)(2)");
        viruses[1, 2] = GameObject.Find("coronavirus (1)(2)");
        viruses[2, 2] = GameObject.Find("coronavirus (2)(2)");
        viruses[3, 2] = GameObject.Find("coronavirus (3)(2)");
        viruses[4, 2] = GameObject.Find("coronavirus (4)(2)");
        viruses[0, 3] = GameObject.Find("coronavirus (0)(3)");
        viruses[1, 3] = GameObject.Find("coronavirus (1)(3)");
        viruses[2, 3] = GameObject.Find("coronavirus (2)(3)");
        viruses[3, 3] = GameObject.Find("coronavirus (3)(3)");
        viruses[4, 3] = GameObject.Find("coronavirus (4)(3)");
        viruses[0, 4] = GameObject.Find("coronavirus (0)(4)");
        viruses[1, 4] = GameObject.Find("coronavirus (1)(4)");
        viruses[2, 4] = GameObject.Find("coronavirus (2)(4)");
        viruses[3, 4] = GameObject.Find("coronavirus (3)(4)");
        viruses[4, 4] = GameObject.Find("coronavirus (4)(4)");

        initialColor = viruses[0, 0].GetComponent<MeshRenderer>().material.color;

        randI = 0;
        randJ = 0;

        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Timer").GetComponent<TimerBehavior>().timeIsRunning)
        {
            if (Mathf.FloorToInt(oneSecond) == 1)
            {
                oneSecond = 0.0f;

                viruses[randI, randJ].GetComponent<MeshRenderer>().material.color = initialColor;
                randI = Random.Range(0, 5);
                randJ = Random.Range(0, 5);
                viruses[randI, randJ].GetComponent<MeshRenderer>().material.color = Color.green;
            }
            oneSecond += Time.deltaTime;
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    viruses[i, j].GetComponent<MeshRenderer>().material.color = initialColor;
                }
            }
        }
    }
}