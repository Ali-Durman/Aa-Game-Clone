using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Cricle : MonoBehaviour
{
    public GameObject Tiny_Circle;
    GameObject Gamedirector;
    void Start()
    {
        Gamedirector = GameObject.FindGameObjectWithTag("Game_Director");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Create_Small_Circle();
        }
    }

    void Create_Small_Circle()
    {
        Instantiate(Tiny_Circle, transform.position, transform.rotation);
        Gamedirector.GetComponent<Game_Director>().SmallCircleShowText();
    }
}
