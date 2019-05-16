using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheapLover : MonoBehaviour
{


    public string cname = "Mary";

    //0 for not sustainable, 1 for sustainable
    public int greens = 0;
    public int meat = 1;
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        /*
        Debug.Log("name: " + cname);
        Debug.Log("green: " + greens.ToString());
        Debug.Log("meat: " + meat.ToString());
        */
    }

    public string getName()
    {
        return cname;
    }

    public int getGreens()
    {
        return greens;
    }

    public int getMeat()
    {
        return meat;
    }
    public void startIdile()
    {
      anim.SetBool("walk", false);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "orderPos")
        {
            //Debug.Log("start ordering");
            anim.SetBool("talkStage", true);
        }
    }
    /*
    void Update()
    {
        anim.SetBool("TestBool", true);
    }
    */
}
