using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notecreat : MonoBehaviour {
    GameObject  allnote;

    void Start () {
 
        GameObject allnote = GameObject.Find("Notes");
    }

    //creatmode中 noteの状態
    void Update () {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            allnote.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {         
            allnote.SetActive(true);
        }
    }
}
