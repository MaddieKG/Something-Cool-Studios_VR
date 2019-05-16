using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tutorialDetectTaco : MonoBehaviour
{
    public float tacoPrice;
    public int tacoPop;

    IEnumerator OnCollisionEnter(Collision col)
    {
        tutorialPointsController pointsScript = GameObject.Find("PointsController").GetComponent<tutorialPointsController>();
        TitleControl titleControl = GameObject.Find("start").GetComponent<TitleControl>();

        if (col.gameObject.name == "taco(Clone)")
        {
            yield return new WaitForSeconds(3);
            ///call something
            Destroy(col.gameObject);
            titleControl.setS3(false);
            titleControl.setStart(true);
            pointsScript.sellTaco(tacoPrice, tacoPop);
        }
    }
}
