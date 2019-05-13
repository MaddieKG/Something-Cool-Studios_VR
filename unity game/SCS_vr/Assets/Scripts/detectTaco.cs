using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class detectTaco : MonoBehaviour
{
    public float tacoPrice;
    public int tacoPop;

    IEnumerator OnCollisionEnter(Collision col)
	{
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        if (col.gameObject.name == "taco(Clone)")
			{
				yield return new WaitForSeconds(3);
                ///call something
				Destroy(col.gameObject);
                System.Math.Round(tacoPrice, 2);
                Debug.Log(tacoPrice);
                pointsScript.sellTaco(tacoPrice, tacoPop);
			}
	}
}
