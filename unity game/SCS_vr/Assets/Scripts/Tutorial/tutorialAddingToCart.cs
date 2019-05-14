using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialAddingToCart : MonoBehaviour
{
    [SerializeField]
    public ProductData beefData, chickenData, gmoLettData, orgLettData;

    public int currentMeat, currentLettuce;

    private bool onPress, conflict;
    private bool ing1In, ing2In, ing3In;
    public Vector3 cartPos;
    public float totalCost;
    private int totalGreen, itemsInCart, customers;
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
        tutorialPointsController pointsScript = GameObject.Find("PointsController").GetComponent<tutorialPointsController>();
        tutorialStartControl startScript = GameObject.Find("StartButton").GetComponent<tutorialStartControl>();
        detectTaco tacoDetector = GameObject.Find("counter").GetComponent<detectTaco>();

        if (ing1In == true && ing2In == true && conflict == false && startScript.start == true && onPress == true)
        {
            //totalCost *= customers;
            setIngredient(ing1Name, ing2Name);
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
        if (col.gameObject.tag == "ingredient1" || col.gameObject.tag == "ingredient2")
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
            if (col.gameObject.name != "RightHandAnchor" && col.gameObject.name != "LeftHandAnchor")
            {
                if (col.gameObject.name != ing1Name && col.gameObject.name != ing2Name)
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
        if (col.gameObject.name != "RightHandAnchor" && col.gameObject.name != "LeftHandAnchor")
        {
            if (col.gameObject.name != ing1Name && col.gameObject.name != ing2Name)
            {
                conflict = false;
            }
        }
        addData(col.gameObject.name, -1);
    }

    private void addData(string name, int multiplier)
    {
        Debug.Log(name);
        TutorialUIController controlUI = GameObject.Find("UIController").GetComponent<TutorialUIController>();
        if (name == "beef")
        {
            totalCost += multiplier * beefData.money;
            totalGreen += multiplier * beefData.green;
            Debug.Log("check beef ");
        }
        else if (name == "chicken")
        {
            totalCost += multiplier * chickenData.money;
            totalGreen += multiplier * chickenData.green;
            Debug.Log("check chicken");
        }
        else if (name == "gmoLettuce")
        {
            totalCost += multiplier * gmoLettData.money;
            totalGreen += multiplier * gmoLettData.green;
            Debug.Log("check gmo");
            Debug.Log(name + totalCost);
        }
        else if (name == "orgLettuce")
        {
            totalCost += multiplier * orgLettData.money;
            totalGreen += multiplier * orgLettData.green;
            Debug.Log("check org");
        }

        Debug.Log("done : " + totalCost);
        controlUI.setCostText(totalCost * customers);
    }

    private void setIngredient(string meat, string lettuce)
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
    }
}
