using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MovieList : MonoBehaviour
{

    
    public VideoClip[] videos;

    private int a = 0;
    void Start()
    {
        this.GetComponent<VideoPlayer>().clip = videos[0];
        this.GetComponent<VideoPlayer>().Play();
    }
    void Update()
    {

        //左右　選択メニュー、ビデオの変更
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            a--;
            if (a <0)
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
                this.GetComponent<VideoPlayer>().clip = videos[0];
                this.GetComponent<VideoPlayer>().Play();
                break;
            case 1:
                this.GetComponent<VideoPlayer>().clip = videos[1];
                this.GetComponent<VideoPlayer>().Play();
                break;
            case 2:
                this.GetComponent<VideoPlayer>().clip = videos[2];
                this.GetComponent<VideoPlayer>().Play();
                break;
        }
    }
}


