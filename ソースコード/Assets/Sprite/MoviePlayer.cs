using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MoviePlayer : MonoBehaviour
{

    bool pause = false;

    public VideoPlayer vp;
    //ビデオ　ポーズ状態
    void Update()
    {
        //ESC　ビデオ止める、もう押すと一回続く　
        if (pause == false && Input.GetKeyDown(KeyCode.Escape))
        {
            pause = true;
            vp.Pause();
        }
        else if (pause == true && Input.GetKeyDown(KeyCode.Escape))
        {
            pause = false;
            vp.Play();
        }
    }
}
