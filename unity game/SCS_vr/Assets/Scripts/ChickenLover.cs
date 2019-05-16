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
    /*
    public void startIdile()
    {
      Debug.Log("chicken idile");
      anim.SetBool("walkBool", false);
      Debug.Log("walking anim");
    }
    public void startWalk()
    {
      Debug.Log("chicken walk");
      anim.SetBool("walkBool", true);
      Debug.Log("walking anim");
    }
    */
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "orderPos")
        {
            ordering = true;
            anim.SetBool("talkStage", true);
        }
    }
    void Update()
    {
        recievedTaco = GameObject.Find("plate");
        tacoInfo = GameObject.Find("cart");
        detectTaco detectTaco = recievedTaco.GetComponent<detectTaco>();
        addingToCart addingToCart = tacoInfo.GetComponent<addingToCart>();
        if(detectTaco.onPlate == true)
        {
          Debug.Log("taco on plate");
          //beef = 0, chicken = 1, gmoLettuce = 0, other lettuce = 1
          if(ordering == true)
          {
            if(addingToCart.currentMeat == 1)
            {
              anim.SetBool("gotTacoHappy", true);
            }
            else
            {
              anim.SetBool("gotTacoSad", true);
            }
          }
          else
          {
            anim.SetBool("walkBool", true);
          }
        }
    }
}
