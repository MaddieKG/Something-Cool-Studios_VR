using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingToCart : MonoBehaviour
{
    [SerializeField]
    public ProductData beefData, chickenData, gmoLettData, orgLettData, picoData, guacData;

    public int currentMeat, currentLettuce, currentTopping;

    private bool onPress, conflict;
    private bool ing1In, ing2In, ing3In;
    public Vector3 cartPos;
    public float totalCost;
    private int totalGreen, itemsInCart, customers;
    private string ing1Name, ing2Name, ing3Name;

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
        detectTaco tacoDetector = GameObject.Find("plate").GetComponent<detectTaco>();

        if (ing1In == true && ing2In == true && ing3In == true && conflict == false && startScript.start == true && onPress == true)
        {
            //totalCost *= customers;
            setIngredient(ing1Name, ing2Name, ing3Name);
            Debug.Log(currentTopping);
            onPress = false;
            tacoDetector.tacoPrice = (totalCost * 3) + totalCost;
            totalCost *= customers;
            totalGreen *= customers;
            pointsScript.buyProducts(totalCost, totalGreen);
            startScript.ready = true;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        addData(col.gameObject.name, 1);
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "ingredient1" || col.gameObject.tag == "ingredient2" || col.gameObject.tag == "ingredient3")
        {
            if (col.gameObject.tag == "ingredient1" && ing1In == false)
            {
                ing1In = true;
                ing1Name = col.gameObject.name;
            }
            if (col.gameObject.tag == "ingredient2" && ing2In == false)
            {
                ing2In = true;
                ing2Name = col.gameObject.name;
            }
            if (col.gameObject.tag == "ingredient3" && ing3In == false)
            {
                ing3In = true;
                ing3Name = col.gameObject.name;
            }
            if (col.gameObject.name != "RightHandAnchor" && col.gameObject.name != "LeftHandAnchor")
            {
                if (col.gameObject.name != ing1Name && col.gameObject.name != ing2Name && col.gameObject.name != ing3Name)
                {
                    Debug.Log(col.gameObject.name);
                    conflict = true;
                    Debug.Log("conflict = " + conflict);
                }
            }
        }
        
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "ingredient1" && ing1In == true)
        {
            ing1In = false;
            ing1Name = null;
        }
        if (col.gameObject.tag == "ingredient2" && ing2In == true)
        {
            ing2In = false;
            ing2Name = null;
        }
        if (col.gameObject.tag == "ingredient3" && ing3In == true)
        {
            ing3In = false;
            ing3Name = null;
        }
        if (col.gameObject.name != "RightHandAnchor" && col.gameObject.name != "LeftHandAnchor")
        {
            if (col.gameObject.name != ing1Name && col.gameObject.name != ing2Name && col.gameObject.name != ing3Name)
            {
                conflict = false;
            }
        }
        addData(col.gameObject.name, -1);
    }

    private void addData(string name, int multiplier)
    {
        //Debug.Log(name);
        UIController controlUI = GameObject.Find("UIController").GetComponent<UIController>();
        if (name == "beef")
        {
            totalCost += multiplier * beefData.money;
            totalGreen += multiplier * beefData.green;
            //Debug.Log("check beef ");
        }
        else if (name == "chicken")
        {
            totalCost += multiplier * chickenData.money;
            totalGreen += multiplier * chickenData.green;
            //Debug.Log("check chicken");
        }
        else if (name == "gmoLettuce")
        {
            totalCost += multiplier * gmoLettData.money;
            totalGreen += multiplier * gmoLettData.green;
            //Debug.Log("check gmo");
            //Debug.Log(name + totalCost);
        }
        else if (name == "orgLettuce")
        {
            totalCost += multiplier * orgLettData.money;
            totalGreen += multiplier * orgLettData.green;
            //Debug.Log("check org");
        }
        else if (name == "pico")
        {
            totalCost += multiplier * picoData.money;
            totalGreen += multiplier * picoData.green;
            //Debug.Log("pico picked");
        }
        else if (name == "guac")
        {
            totalCost += multiplier * guacData.money;
            totalGreen += multiplier * guacData.green;
            //Debug.Log("guac picked");
        }

        //Debug.Log("done : " + totalCost);
        controlUI.setCostText(totalCost * customers);
    }

    private void setIngredient(string meat, string lettuce, string topping)
    {
        if (meat == "beef")
        {
            currentMeat = 0;
        }
        else
        {
            currentMeat = 1;
        }
        if (lettuce == "gmoLettuce")
        {
            currentLettuce = 0;
        }
        else
        {
            currentLettuce = 1;
        }
        if (topping == "pico")
        {
            currentTopping = 0;
        }
        else
        {
            currentTopping = 1;
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
                    totalCost += beefData.Money * 2;
                    totalGreen += beefData.Green * 2;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentMeat = 0;
                    controlUI.setCostText(totalCost);
                }
                else if (col.gameObject.name == "chicken")
                {
                    totalCost += chickenData.Money;
                    Debug.Log(totalCost.ToString());
                    totalGreen += chickenData.Green * 2;
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
                    totalCost += gmoLettData.Money * 2;
                    Debug.Log(totalCost.ToString());
                    totalGreen += gmoLettData.Green * 2;
                    itemsInCart += 1;
                    Destroy(col.gameObject);
                    currentLettuce = 0;
                    controlUI.setCostText(totalCost);
                }
              else if (col.gameObject.name == "orgLettuce")
              {
                    totalCost += orgLettData.Money * 2;
                    Debug.Log(totalCost.ToString());
                    totalGreen += orgLettData.Green * 2;
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
