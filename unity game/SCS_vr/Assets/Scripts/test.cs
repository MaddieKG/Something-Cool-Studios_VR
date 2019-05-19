using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class test : MonoBehaviour
{
    public bool onPlate = false;
    public bool moveUp = false;

  void OnTriggerEnter(Collider col)
	{
      if (col.gameObject.name == "plate")
			{
        Debug.Log("on plate 1:" + onPlate);
        setTacoTrue();
        Debug.Log("on plate 2:" + onPlate);
				//Destroy(col.gameObject);
			}
      Debug.Log(col.gameObject.name);
	}
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
