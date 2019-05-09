using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectTaco : MonoBehaviour
{
	public static bool gotTaco = false;
	IEnumerator OnCollisionEnter(Collision col)
	{
			if (col.gameObject.name == "taco(Clone)")
			{
				gotTaco = true;
				yield return new WaitForSeconds(1);
        ///call something
				Destroy(col.gameObject);
				//check customer preference and update points
			}
	}
}
