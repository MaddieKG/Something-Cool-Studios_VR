using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cole_Animation_Test_Script : MonoBehaviour
{

    private Animator anim;



    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void walk()
    {
        anim.SetBool("TestBool", true);
        //anim.SetBool("TestBool", false);
        Debug.Log("walk");
    }
}
