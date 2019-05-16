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
        Debug.Log("on plate:" + onPlate);
        onPlate = true;
        Debug.Log("on plate:" + onPlate);
				yield return new WaitForSeconds(1);
                ///call something
        onPlate = false;
        Debug.Log("on plate:" + onPlate);
				Destroy(col.gameObject);
        Debug.Log(tacoPrice);
        pointsScript.sellTaco(tacoPrice, tacoPop);

			}
	}
  /*
  void OnCollisionExit(Collision col)
  {
    if (col.gameObject.name == "taco(Clone)")
    {
      onPlate = false;
    }
  }
  */
}
