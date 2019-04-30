using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeggieLover : MonoBehaviour {

    public string cname = "Jim";
    public string greens = "anti";
    public string meat = "pro";
    //public Cole_Animation_Test_Script ani;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        Debug.Log("name: " + cname);
        Debug.Log("green: " + greens);
        Debug.Log("meat: " + meat);
    }
    /*
    public void walk()
    {
        anim.SetBool("TestBool", true);
        //anim.SetBool("TestBool", false);
        Debug.Log("walk");
    }
    
    void OnEnable()
    {
        transform.Rotate(0, -90, 0);
        walk();
    }
    */
    // Update is called once per frame
    void Update()
    {
        //if (movebool == true)
        //{
            //transform.Rotate(0, 90, 0);
            //walk();
            anim.SetBool("TestBool", true);
        //}
    }
    /*
    void walk()
    {
        //yield return new WaitForSeconds(3);
        anim.SetBool("TestBool", true);
        //anim.SetBool("TestBool", false);
        Debug.Log("walk");
    }
    */
}
