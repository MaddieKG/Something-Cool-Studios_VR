using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectTaco : MonoBehaviour
{
    
    IEnumerator OnCollisionEnter(Collision col)
	{
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        if (col.gameObject.name == "taco(Clone)")
			{
				yield return new WaitForSeconds(3);
        ///call something
				Destroy(col.gameObject);
                pointsScript.sellTaco(1, 2);
				//check customer preference and update points
			}
	}
}
