﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCust : MonoBehaviour
{


    public string cname = "Paul";

    //0 for not sustainable, 1 for sustainable
    public int greens;
    public int meat;
    public Animator anim;
    private bool ordering = false;
    public GameObject recievedTaco;
    public GameObject tacoInfo;

    void Start()
    {
        greens = Random.Range(0, 2);
        meat = Random.Range(0, 2);
        anim = GetComponent<Animator>();
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
      anim.SetBool("walk", false);
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
