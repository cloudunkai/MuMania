using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMeter : MonoBehaviour
{
    
    float rm;//移動位置
    GameObject needle;//移動オブジェクト
 
    void Start()
    {
        needle = transform.Find("needle").gameObject;        
    }


    void Update()
    {
        //Y軸移動
        rm = PlayerPrefs.GetInt("RockMeter");
        needle.transform.localPosition = new Vector3(2, (rm - 25) / 25, 0);
       
    }
}
