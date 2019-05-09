using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeggieLover : MonoBehaviour {

    public string cname = "Jim";
    public string greens = "anti";
    public string meat = "pro";
    public static Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        //Debug.Log("name: " + cname);
        //Debug.Log("green: " + greens);
        //Debug.Log("meat: " + meat);
    }

    public string getName()
    {
        return cname;
    }

    public string getGreens()
    {
        return greens;
    }

    // Update is called once per frame
    void Update()
    {
        //anim.SetBool("TestBool", true);
    }
}
