using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganicLover : MonoBehaviour {

    public string cname = "Jim";

    //0 for not sustainable, 1 for sustainable
    public int greens = 1;
    public int meat = 1;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Debug.Log("name: " + cname);
        Debug.Log("green: " + greens.ToString());
        Debug.Log("meat: " + meat.ToString());
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

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("TestBool", true);
    }
}
