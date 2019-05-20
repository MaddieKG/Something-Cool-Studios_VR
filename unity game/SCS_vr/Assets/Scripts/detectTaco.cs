using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class detectTaco : MonoBehaviour
{
    public float tacoPrice;
    public int tacoPop;
    public bool onPlate = false;
    public bool moveUp = false;

  IEnumerator OnCollisionEnter(Collision col)
	{
      PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
      if (col.gameObject.name == "taco(Clone)")
	    {
                Debug.Log("its on plate");
                onPlate = true;
                //setTacoTrue();
                //Debug.Log("on plate 2:" + onPlate);
				yield return new WaitForSeconds(2);
				Destroy(col.gameObject);
            moveUpTrue();
            //setTacoFalse(); 
            //Debug.Log(tacoPrice);
            pointsScript.sellTaco(tacoPrice, tacoPop);

			}
      Debug.Log("collided");
	}
  
  /*
  void OnTriggerEnter(Collider col)
	{
      PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
      if (col.gameObject.name == "taco(Clone)")
			{
        Debug.Log("on plate 1:" + onPlate);
        setTacoTrue();
        Debug.Log("on plate 2:" + onPlate);
				Destroy(col.gameObject);
        //Debug.Log(tacoPrice);
        pointsScript.sellTaco(tacoPrice, tacoPop);

			}
      //Debug.Log("collided");
	}*/
    

  private void setTacoTrue()
  {
        Debug.Log("set taco true");
    onPlate = true;
  }
  public void setTacoFalse()
  {
    onPlate = false;
  }
  public void moveUpTrue()
  {
    moveUp = true;
        Debug.Log("move up: " + moveUp);
  }
  public void moveUpFalse()
  {
    moveUp = false;
  }
}
