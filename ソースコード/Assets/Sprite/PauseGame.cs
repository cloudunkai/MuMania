using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    
    public bool pause = false;
   
    GameObject pausegame;
    void Start()
    {
        pausegame = GameObject.Find("Pausebutton");        
        pausegame.SetActive(false);
    }

    void Update()
    {
     //ゲーム中のPAUSEメニュー　  
        if (pause == false && Input.GetKeyDown(KeyCode.Escape))
        {
            pause = true;
            pausegame.SetActive(true);
        }
        else if (pause == true && Input.GetKeyDown(KeyCode.Escape))
        {
            pause = false;
            pausegame.SetActive(false);
        }
    }
}
