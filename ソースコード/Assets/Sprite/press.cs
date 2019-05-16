using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class press : MonoBehaviour
{
    int a = 0;

    void Update()
    {
        //MUSIC選択メニュー
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            a--;
            if (a < 0) a = 2;

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            a++;
        }
        //spaceで確認
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (a % 3)
            {
                case 0:
                    SceneManager.LoadScene(1);
                    break;
                case 1:
                    SceneManager.LoadScene(4);
                    break;
                case 2:
                    SceneManager.LoadScene(6);
                    break;
            }
        }

    }
}
