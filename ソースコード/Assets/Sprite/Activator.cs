using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{


    SpriteRenderer sr;//押したキーの色
    public KeyCode key;//キー
    bool active = false;//キーを押すが

    GameObject note, gm, allnote, act;
    Color old;//色

    //譜面を作るモード

    public bool createMode;
    public GameObject n;
    public GameObject Tx;//effect

    //PAUSE
    public bool pause = false;
    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        //利用したオブジェクト
        allnote = GameObject.Find("Notes");
        gm = GameObject.Find("GameManager");
        act = GameObject.Find("Activators");
        old = sr.color;
    }

    void Update()
    {
        //ESC　pause
        if (pause == false && Input.GetKeyDown(KeyCode.Escape))
        {
            pause = true;
        }
        else if (pause == true && Input.GetKeyDown(KeyCode.Escape))
        {
            pause = false;
        }

        //F1は　譜面を作るモード
        if (Input.GetKeyDown(KeyCode.F1))
        {
            createMode = true;
            allnote.SetActive(false);
            gm.SetActive(false);
            act.transform.position = new Vector3(-2.909272f, 12, 0);//キー位置変更

        }
        //F2閉める
        else if (Input.GetKeyDown(KeyCode.F2))
        {
            createMode = false;
            allnote.SetActive(true);
            gm.SetActive(true);
            act.transform.position = new Vector3(-2.909272f, 5.520675f, 0);//戻る
        }
        //noteを生成　譜面を作る
        if (createMode)
        {
            if (Input.GetKeyDown(key))
                Instantiate(n, transform.position, Quaternion.identity);
        }
        else
        {

            if (pause == false)
            {
                if (Input.GetKeyDown(key))
                    StartCoroutine(Pressed());
            }
            //エフェクト

            if (Input.GetKeyDown(key) && active && pause == false)
            {
                Destroy(note);
                Instantiate(Tx, transform.position, Quaternion.identity);
                gm.GetComponent<GameManager>().AddStreak();
                AddScore();
                active = false;

            }
            //長押しエフェクト
            if (Input.GetKey(key) && active && pause == false)
            {
                Instantiate(Tx, transform.position, Quaternion.identity);

            }

        }



    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //win flag
        if (col.gameObject.tag == "WinNote")
            gm.GetComponent<GameManager>().Win();

        if (col.gameObject.tag == "Note")
            note = col.gameObject;

        active = true;


    }

    void OnTriggerExit2D(Collider2D col)
    {
        active = false;
        gm.GetComponent<GameManager>().ResetStreak();
        //ESC　PAUSE
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            active = false;
        }
    }
    void AddScore()
    {
        //スコア
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + gm.GetComponent<GameManager>().GetScore());
    }
    IEnumerator Pressed()
    {

        sr.color = new Color(0, 0, 0);//押したキーを黒になる
        yield return new WaitForSeconds(0.05f);//戻る時間
        sr.color = old;//back color
    }

}
