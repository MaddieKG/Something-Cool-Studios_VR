using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingToCart : MonoBehaviour
{
    [SerializeField]
    public ProductData beefData, chickenData, gmoLettData, orgLettData;
    public int currentMeat, currentLettuce;
    
    private bool onPress;
    private bool ing1In, ing2In, ing3In;
    public Vector3 cartPos;
    public int totalGreen, itemsInCart, customers;
    public float totalCost;
    private string ing1Name, ing2Name;

    void Start()
    {
        ing1In = false; 
        ing2In = false;
        ing3In = false;
        onPress = true;
        totalCost = 0;
        totalGreen = 0;
        itemsInCart = 0;
        customers = 6;
    }

    void Update()
    {
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        StartControl startScript = GameObject.Find("StartButton").GetComponent<StartControl>();
        detectTaco tacoDetector = GameObject.Find("counter").GetComponent<detectTaco>();

        if (itemsInCart == 2 && startScript.start == true && onPress == true)
        {
            //totalCost *= customers;
            onPress = false;
            tacoDetector.tacoPrice = (totalCost * 3) + totalCost;
            totalCost *= customers;
            totalGreen *= customers;
            pointsScript.buyProducts(totalCost, totalGreen);

        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ingredient1" && ing1In == false) {
            Debug.Log("ingredient 1 in");
        }
        if (col.gameObject.tag == "ingredient2" && ing2In == false)
        {
            Debug.Log("ingredient 2 in");
        }
        if (ing1In == true && ing2In == true)
        {
            Debug.Log("Both ingredient in");
        }
    }
    /**
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
                    totalCost += beefData.money;
                    totalGreen += beefData.green;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentMeat = 0;
                    controlUI.setCostText(totalCost);
                }
                else if (col.gameObject.name == "chicken")
                {
                    totalCost += chickenData.money;
                    totalGreen += chickenData.green;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentMeat = 1;
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
                    totalCost += gmoLettData.money;
                    totalGreen += gmoLettData.green;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentLettuce = 0;
                    controlUI.setCostText(totalCost);
                }
              else if (col.gameObject.name == "orgLettuce")
              {
                    totalCost += orgLettData.money;
                    totalGreen += orgLettData.green;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentLettuce = 1;
                    controlUI.setCostText(totalCost);
                }
                two = true;
            }
        }
    }*/
}
