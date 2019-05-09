using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cole_Animation_Test_Script : MonoBehaviour {

private Animator anim;



	// Use this for initialization
	void Start () {
			anim = GetComponent<Animator>();
	}


    //Need to idle until 1 person purchases a taco
    //If your purchasing a taco, then transition from "Stop walking" to "talking", then after purchase, turn and walk away
   void Update(){
        if (Input.GetKey(KeyCode.Keypad1))
        {
            anim.SetInteger("Purchase_Stage", 1);
        }
        else if (Input.GetKey(KeyCode.Keypad2))
        {
            anim.SetInteger("Purchase_Stage", 2);
        }
        else if (Input.GetKey(KeyCode.Keypad3))
        {
            anim.SetInteger("Purchase_Stage", 3);
        }
    }
    //


    // Update is called once per frame
    public void walk()
    {
        anim.SetBool("TestBool", true);
        //anim.SetBool("TestBool", false);
        Debug.Log("walk");
    }

}
