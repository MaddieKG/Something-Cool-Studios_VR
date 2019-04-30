using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingToCart : MonoBehaviour
{
    [SerializeField]
    public ProductData beefData, chickenData, gmoLettData, orgLettData;

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
        //Debug.Log(itemsInCart.ToString());
        proController = GameObject.Find("ProductController");
        ProductController proControl = proController.GetComponent<ProductController>();
        startButton = GameObject.Find("StartButton");
        StartControl startScript = startButton.GetComponent<StartControl>();
        

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
                    totalCost += beefData.Money;
                    Debug.Log(totalCost.ToString());
                    totalGreen += beefData.Green;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                }
                else if (col.gameObject.name == "chicken")
                {
                    //Debug.Log("vegan1 collision detected");
                    totalCost += chickenData.Money;
                    Debug.Log(totalCost.ToString());
                    totalGreen += chickenData.Green;
                    itemsInCart += 1;
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

                    totalCost += gmoLettData.Money;
                    Debug.Log(totalCost.ToString());
                    totalGreen += gmoLettData.Green;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                }
              else if (col.gameObject.name == "orgLettuce")
              {
                    //Debug.Log("vegan2 collision detected");

                    totalCost += orgLettData.Money;
                    Debug.Log(totalCost.ToString());
                    totalGreen += orgLettData.Green;
                    itemsInCart += 1;
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