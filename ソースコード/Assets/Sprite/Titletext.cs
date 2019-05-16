using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Titletext : MonoBehaviour
{

    public GameObject GO;
    int a = 0;

    void Update()
    {
        //メニュー　ミュージックタイトルの変更
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            a--;
            if (a < 0)
            {
                a = 2;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            a++;
        }
        switch (a % 3)
        {
            case 0:
                GO.GetComponent<Text>().text = "And So It Begins by Artificial Music ";
                break;
            case 1:
                GO.GetComponent<Text>().text = "bananapeelz-LOLREmix ";
                break;
            case 2:
                GO.GetComponent<Text>().text = "CMA - You're Not Alone ";
               break;
        }

       
    }
}