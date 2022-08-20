using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Small_Circle_Code : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool MovementControl = false;
    GameObject OyunDirektor;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        OyunDirektor = GameObject.FindGameObjectWithTag("Game_Director");
    }

    void FixedUpdate()
    {
        if (!MovementControl)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Spinning_Circle_Tag")
        {
            transform.SetParent(col.transform);
            MovementControl = true;
        }
        if (col.tag == "Small_Circle")
        {
            OyunDirektor.GetComponent<Game_Director>().OyunBitti();
        }
    }
}
