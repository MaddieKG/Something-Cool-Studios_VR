using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectTaco : MonoBehaviour
{
	//IEnumerator
	IEnumerator OnCollisionEnter(Collision col)
	{
			if (col.gameObject.name == "taco(Clone)")
			{
				yield return new WaitForSeconds(3);
            ///call something
				Destroy(col.gameObject);
				//check customer preference and update points
			}
	}
}
