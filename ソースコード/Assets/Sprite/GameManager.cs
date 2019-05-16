using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int multiplier = 1;//スコア倍数
    int streak = 0;//combo
    
    void Start()
    {
        //初期值
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("RockMeter", 250);//ｈｐ
        PlayerPrefs.SetInt("Streak", 0);//combo
        PlayerPrefs.SetInt("HighStreak", 0);
        PlayerPrefs.SetInt("Mult", 1);//１倍
        PlayerPrefs.SetInt("NotesHit", 0);//Hit数
        PlayerPrefs.SetInt("Start", 1);    
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
    }
    void OnTriggerExit2D(Collider2D col)
    {
        //hp减る　comboゼロになる
        streak = 0;
        PlayerPrefs.SetInt("RockMeter", PlayerPrefs.GetInt("RockMeter") - 5);

    }
    
    public void AddStreak()
    {
        //HP表示
        if (PlayerPrefs.GetInt("RockMeter") < 250)
            PlayerPrefs.SetInt("RockMeter", PlayerPrefs.GetInt("RockMeter") + 1);
        //加点
        streak++;

        if (streak >= 24)
            multiplier = 4;
        else if (streak >= 16)
            multiplier = 3;

        else if (streak >= 8)
            multiplier = 2;
        else
            multiplier = 1;

        if (streak > PlayerPrefs.GetInt("HighStreak"))
            PlayerPrefs.SetInt("HighStreak", streak);

        PlayerPrefs.SetInt("NotesHit", PlayerPrefs.GetInt("NotesHit") + 1);

        UpdateGUI();

    }

    public void ResetStreak()
    {
        //hp＝0　lose　

        if (PlayerPrefs.GetInt("RockMeter") <= 0)

            Lose();
        //miss 1になる
        multiplier = 1;
        UpdateGUI();
    }

    //loseシーン
    void Lose()
    {
        PlayerPrefs.SetInt("Start", 0);

        SceneManager.LoadScene(3);
    }
    public void Win()
    {
        PlayerPrefs.SetInt("Start", 0);

        if (PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("Score"))
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
        SceneManager.LoadScene(2);

    }
    void UpdateGUI()
    {
        PlayerPrefs.SetInt("Streak", streak);
        PlayerPrefs.SetInt("Mult", multiplier);
    }


    public int GetScore()
    {
        return 100 * multiplier;
    }
}
