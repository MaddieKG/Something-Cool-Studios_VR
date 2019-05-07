using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatLover : MonoBehaviour {

    public string cname = "Bob";
    public string greens = "pro";
    public string meat = "anti";
    private Animator anim;

    void Start () {
        anim = GetComponent<Animator>();
        Debug.Log("name: " + cname);
        Debug.Log("green: " + greens);
        Debug.Log("meat: " + meat);
    }

    public string getName()
    {
        return cname;
    }

    public string getGreens()
    {
        return greens;
    }

    public string getMeat()
    {
        return meat;
    }

    public void walk()
    {
      anim.SetBool("TestBool", true);
    }

    void Update()
    {
        //anim.SetBool("TestBool", true);
    }
}
