using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class detectTaco : MonoBehaviour
{
    public float tacoPrice;
    public int tacoPop;
    public bool onPlate = false;
    public bool moveUp = false;
    public int counter = 0;
    public GameObject chanceCustomer, chanceCustPos;

    IEnumerator OnCollisionEnter(Collision col)
	{
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        if (col.gameObject.tag == "taco")
	    {
            onPlate = true;
            Debug.Log("on plate :" + onPlate);
	    	yield return new WaitForSeconds(1);
            onPlate = false;
            counter += 1;
            Destroy(col.gameObject);
            //Debug.Log(tacoPrice);
            pointsScript.sellTaco(tacoPrice, tacoPop);
            if (counter == 6)
            {
                Instantiate(chanceCustomer, chanceCustPos.transform.position, transform.rotation);
            }

		}
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
    onPlate = true;
  }
  public void setTacoFalse()
  {
    onPlate = false;
  }
  public void moveUpTrue()
  {
    moveUp = true;
  }
  public void moveUpFalse()
  {
    moveUp = false;
  }
}
