﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingToCart : MonoBehaviour
{
    [SerializeField]
    public ProductData beefData, chickenData, gmoLettData, orgLettData;
    public string currentMeat;
    public string currentLettuce;

    private GameObject startButton, controller, proController;
    private bool onPress;
    public bool one, two, three;
    public Vector3 cartPos;
    public int totalCost, totalGreen, itemsInCart;

    void Start()
    {
        controller = GameObject.Find("UIController");
        UIController controlUI = controller.GetComponent<UIController>();
        proController = GameObject.Find("ProductController");
        ProductController proControl = proController.GetComponent<ProductController>();

        one = false;
        two = false;
        three = false;
        onPress = true;
        totalCost = 0;
        totalGreen = 0;
        itemsInCart = 0;
    }

    void Update()
    {
        proController = GameObject.Find("ProductController");
        ProductController proControl = proController.GetComponent<ProductController>();
        startButton = GameObject.Find("StartButton");
        StartControl startScript = startButton.GetComponent<StartControl>();
        detectTaco tacoDetector = GameObject.Find("counter").GetComponent<detectTaco>();

        
        if (itemsInCart > 1 && startScript.start == true && onPress == true)
        {
            totalCost *= 2;
            onPress = false;
            proControl.buyProducts(totalCost, totalGreen);

        }
    }

    void OnCollisionEnter(Collision col)
    {
        ProductController proControl = gameObject.GetComponent<ProductController>();

        controller = GameObject.Find("UIController");
        UIController controlUI = controller.GetComponent<UIController>();

        if (col.gameObject.tag == "ingredient1")
        {
            //if ingredient already choosen
            if (one == true)
            {
                col.gameObject.transform.position = new Vector3(-1,1,-2);
            }
            //picking meat to put in taco
            else if (one == false)
            {
                //updating points system based on choice of meat
                if (col.gameObject.name == "beef")
                {
                    totalCost += beefData.Money * 2;
                    totalGreen += beefData.Green * 2;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentMeat = "anti";
                    controlUI.setCostText(totalCost);
                }
                else if (col.gameObject.name == "chicken")
                {
                    totalCost += chickenData.Money;
                    Debug.Log(totalCost.ToString());
                    totalGreen += chickenData.Green * 2;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentMeat = "pro";
                    controlUI.setCostText(totalCost);
                }
                one = true;
            }
        }
        else if (col.gameObject.tag == "ingredient2")
        {
          //if ingredient already chosen
          if(two == true)
          {
            col.gameObject.transform.position = new Vector3(-1,1,-2);
          }
          //choosing which lettuce to put in taco
          else if (two == false)
          {
            //updating points system based on choice of lettuce
              if (col.gameObject.name == "gmoLettuce")
              {
                    totalCost += gmoLettData.Money * 2;
                    Debug.Log(totalCost.ToString());
                    totalGreen += gmoLettData.Green * 2;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentLettuce = "anti";
                    controlUI.setCostText(totalCost);
                }
              else if (col.gameObject.name == "orgLettuce")
              {
                    totalCost += orgLettData.Money * 2;
                    Debug.Log(totalCost.ToString());
                    totalGreen += orgLettData.Green * 2;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentLettuce = "pro";
                    controlUI.setCostText(totalCost);
                }
                two = true;
            }
        }
    }
}
