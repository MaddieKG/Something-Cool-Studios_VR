using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingToCart : MonoBehaviour
{
    private GameObject startButton, controller;
    private bool onPress;
    public bool one, two, three;
    public Vector3 cartPos;
    public int totalCost, totalGreen, itemsInCart;

    void Start()
    {
        controller = GameObject.Find("UIController");

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
        startButton = GameObject.Find("StartButton");
        StartControl startScript = startButton.GetComponent<StartControl>();

        controller = GameObject.Find("UIController");
        UIController controlScript = controller.GetComponent<UIController>();

        if (startScript.start == true && itemsInCart > 1 && onPress == true)
        {
            onPress = false;
            controlScript.buyProducts(totalCost, totalGreen);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        ProductController proControl = gameObject.GetComponent<ProductController>();
        //Debug.Log("line  18: "+ one);
        if (col.gameObject.tag == "ingredient1")
        {
            if (one == true)
            {
                //Debug.Log("ingredient1 already picked");
                //Debug.Log("line 24(t): " + one);
                col.gameObject.transform.position = new Vector3(-1,1,-2);
            }
            else if (one == false)
            {
                //Debug.Log("line 29(f): " + one);
                if (col.gameObject.name == "beef")
                {
                    //Debug.Log("nonvegan1 collision detected");
                    /**totalCost += proControl.money;
                    totalGreen += proControl.green;
                    itemsInCart += 1;**/
                    Destroy(col.gameObject);
                }
                else if (col.gameObject.name == "chicken")
                {
                    //Debug.Log("vegan1 collision detected");
                    /**totalCost += proControl.money;
                    totalGreen += proControl.green;
                    itemsInCart += 1;**/
                    Destroy(col.gameObject);
                }
                one = true;
                //Debug.Log("line 41(t): " + one);
            }
        }
        else if (col.gameObject.tag == "ingredient2")
        {
          if(two == true)
          {
            //Debug.Log("ingredient2 already picked");
            col.gameObject.transform.position = new Vector3(-1,1,-2);
          }
          else if (two == false)
          {
              if (col.gameObject.name == "gmoLettuce")
              {
                    //Debug.Log("nonvegan2 collision detected");
                    /**
                    totalCost += proControl.money;
                    totalGreen += proControl.green;
                    itemsInCart += 1;**/
                    Destroy(col.gameObject);
                }
              else if (col.gameObject.name == "orgLettuce")
              {
                    //Debug.Log("vegan2 collision detected");
                    /**
                    totalCost += proControl.money;
                    totalGreen += proControl.green;
                    itemsInCart += 1;**/
                    Destroy(col.gameObject);
                }
                two = true;
            }
        }
        /**
        else if (col.gameObject.tag == "ingredient3")
        {
          if(three == true)
          {
            //Debug.Log("ingredient3 already picked");
            col.gameObject.transform.position = new Vector3(-1,1,-2);
          }
          else if (three == false)
          {
              if (col.gameObject.name == "nonvegan3")
              {
                    //Debug.Log("nonvegan3 collision detected");
                    Destroy(col.gameObject);
                    //change points
                }
              else if (col.gameObject.name == "vegan3")
              {
                    //Debug.Log("vegan3 collision detected");
                    Destroy(col.gameObject);
                    //change points
                }
                three = true;
            }
        }**/
    }
}