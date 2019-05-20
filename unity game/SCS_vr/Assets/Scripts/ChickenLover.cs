using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenLover : MonoBehaviour
{


    public string cname = "Andy";

    //0 for not sustainable, 1 for sustainable
    public int greens = 0;
    public int meat = 1;
    public Animator anim;
    private bool ordering = false;
    public GameObject recievedTaco;
    public GameObject tacoInfo;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        /*
        Debug.Log("name: " + cname);
        Debug.Log("green: " + greens.ToString());
        Debug.Log("meat: " + meat.ToString());
        */
    }

    public string getName()
    {
        return cname;
    }

    public int getGreens()
    {
        return greens;
    }

    public int getMeat()
    {
        return meat;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "orderPos")
        {
            ordering = true;
            anim.SetBool("talkStage", true);
        }
    }

    private IEnumerator waitWalking()
    {
        Debug.Log("moving up!");
        anim.SetBool("walkBool", true);
      yield return new WaitForSeconds(4);
      anim.SetBool("walkBool", false);
    }

    void Update()
    {
        //recievedTaco = GameObject.Find("plate");
        //tacoInfo = GameObject.Find("cart");
        detectTaco detectScript = GameObject.Find("plate").GetComponent<detectTaco>();
        addingToCart cartScript = GameObject.Find("cart").GetComponent <addingToCart>();
        //detectTaco detectTaco = recievedTaco.GetComponent<detectTaco>();
        //addingToCart addingToCart = tacoInfo.GetComponent<addingToCart>();
       // Debug.Log("ChickenLover on plate: " + detectTaco.onPlate);
        if(detectScript.onPlate == true)
        {
          //Debug.Log("ChickenLover on plate: " + detectScript.onPlate);
          //detectScript.moveUpTrue();
         // Debug.Log(detectTaco.onPlate);
          //beef = 0, chicken = 1, gmoLettuce = 0, other lettuce = 1
          if(ordering == true)
          {
            if(cartScript.currentMeat == 1)
            {
              anim.SetBool("gotTacoHappy", true);
            }
            else
            {
              anim.SetBool("gotTacoSad", true);
            }

          }
            detectScript.setTacoFalse();
        }
        if(detectScript.moveUp == true)
        {
            //StartCoroutine(waitWalking());
            anim.SetBool("walkBool", true);
            Debug.Log("moving up");
          detectScript.moveUpFalse();

        }

    }
}
