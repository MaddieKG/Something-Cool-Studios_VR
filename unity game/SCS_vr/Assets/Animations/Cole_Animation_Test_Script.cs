using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cole_Animation_Test_Script : MonoBehaviour {

private Animator anim;



	// Use this for initialization
	void Start () {
			anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Return)) {
			anim.SetBool("TestBool", true);
		} else {
			anim.SetBool("TestBool", false);
		}
	}
}
