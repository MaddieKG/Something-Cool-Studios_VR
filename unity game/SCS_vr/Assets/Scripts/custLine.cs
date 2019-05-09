using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class custLine : MonoBehaviour {
	bool t = detectTaco.gotTaco;
	GameObject c = customerManager.current;
	//Animator a = VeggieLover.anim;

	//void OnCollisionEnter(Collision col)
	//IEnumerator Update()
	void Update()
	{
		Debug.Log("taco="+t);
			if (t == true)
			{
				t = false;
				Debug.Log("taco="+t);
				//yield return new WaitForSeconds(1);
				//a.SetBool("TestBool", true);
        ///call something
				Destroy(c.gameObject);
				//check customer preference and update points
			}
	}
/*
	void Update()
	{
			a.SetBool("TestBool", true);
	}
	*/
}
