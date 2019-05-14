using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class detectTaco : MonoBehaviour
{
    public float tacoPrice;
    public int tacoPop;
    public bool onPlate = false;

    IEnumerator OnCollisionEnter(Collision col)
	{
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        if (col.gameObject.name == "taco(Clone)")
			{
        onPlate = true;
				yield return new WaitForSeconds(1);
                ///call something
				Destroy(col.gameObject);
        Debug.Log(tacoPrice);
        pointsScript.sellTaco(tacoPrice, tacoPop);
			}
	}
}
