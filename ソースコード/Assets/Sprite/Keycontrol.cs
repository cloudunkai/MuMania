using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Keycontrol : MonoBehaviour {


    GameObject start, quit;
    
    private int a = 0;
    void Start()
    {
        start = GameObject.Find("Go");
        quit = GameObject.Find("End");
        start.GetComponent<UnityEngine.UI.Button>().Select();
       
    }
    
    void Update()
    {
        //アローキーで選択メニュー　start and quit
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {

            a = a + 1;
            if (a % 2 == 0)
            {
                start.GetComponent<UnityEngine.UI.Button>().Select();
               
            }
            else
            {
                quit.GetComponent<UnityEngine.UI.Button>().Select();
               
            }
        }
    }
}
