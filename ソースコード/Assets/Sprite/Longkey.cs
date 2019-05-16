using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Longkey : MonoBehaviour
{

    Rigidbody2D rb;

    GameObject Lscale;
    public float speed;
    //長押しnote
    void Start()
    {
        Lscale = GameObject.Find("Long");
    }
    void OnTriggerStay2D(Collider2D lo)
    {
        //押したきー反応
        if (lo.gameObject.tag == "Activator")
        {
            Local();
        }
    }
    void OnTriggerExit2D(Collider2D lo)
    {

    }
   public void Local()
    {
        //長さを0になったら　消える
        Lscale.transform.localScale -= new Vector3(0, speed, 0);
        if (Lscale.transform.localScale.y <= 0)
        {
            Destroy(Lscale);
        }
    }

}
