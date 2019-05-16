using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;




public class BF : MonoBehaviour
{
    //button コントロール
    private int a = 0;
    GameObject pausegame;

    //back the title
    public void LoadScene(int a)
    {
        SceneManager.LoadScene(0);
    }
    //back the menu
    public void LoadMenu(int a)
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }

}