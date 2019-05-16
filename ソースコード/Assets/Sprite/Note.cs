using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed;
    bool called = false;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //譜面　Note　スピード変換、creatmodeに使う
        if (PlayerPrefs.GetInt("Start") == 1 && !called)
        {
            rb.velocity = new Vector2(0, -speed);
        }

        if (Input.GetKeyDown(KeyCode.F3)) speed += 1;
        else if (Input.GetKeyDown(KeyCode.F4)) speed -= 1;
        else if (Input.GetKeyDown(KeyCode.F5)) speed = 5;
    }
}
