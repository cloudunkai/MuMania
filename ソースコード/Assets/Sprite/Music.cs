using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{


    public AudioClip[] audios;

    private int a = 0;
    void Start()
    {
        this.GetComponent<AudioSource>().clip = audios[0];
        this.GetComponent<AudioSource>().Play();

    }
    void Update()
    {
        //ミュージック選択メニュー　左右
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            a--;
            if (a < 0)
            {
                a = 2;
            }
            musiclist();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            a++;
            musiclist();

        }

    }
    void musiclist()
    {      
        switch (a % 3)
        {
            case 0:
                this.GetComponent<AudioSource>().clip = audios[0];
                this.GetComponent<AudioSource>().Play();
                break;
            case 1:
                this.GetComponent<AudioSource>().clip = audios[2];
                this.GetComponent<AudioSource>().Play();
                break;
            case 2:
                this.GetComponent<AudioSource>().clip = audios[2];
                this.GetComponent<AudioSource>().Play();
                break;
        }
    }
}
