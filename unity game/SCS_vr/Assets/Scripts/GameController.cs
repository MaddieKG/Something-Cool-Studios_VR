using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text newsText;
    public Text costText, remainingMonText;
    public int popularity, greenPoints, money;
    public Text moneyText, popText, greenText;
    public Text message;

    private bool isRoundActive, isCostShowing;
    private int customersRemaining;
    //private ProductData[] productList;
    private string[] objectives;
    private GameObject costDisplay;
    private GameObject startButton;
    private int monRemaining, cost;

    // Use this for initialization
    void Start () {
        //Allows for initialization
        startButton = GameObject.Find("StartButton");//need a StartButton object
        StartControl startScript = startButton.GetComponent<StartControl>();
        startScript.start = false;

        //Main points
        money = 20; //some value
        greenPoints = 10; //some value
        popularity = 5; //some value

        //cost display stuff
        costDisplay = GameObject.Find("CostDisplay");
        costDisplay.SetActive(true);
        monRemaining = money;
        cost = 0;

        //For translator
        message.text = "Waiting for input...";

        //sets all text
        setObjective();
        setCostText(monRemaining, cost);
        setPointText();
    }
	
	// Update is called once per frame
	void Update () {
        startButton = GameObject.Find("StartButton");//need a StartButton object
        StartControl startScript = startButton.GetComponent<StartControl>();
        if (startScript.start == true)
        {
            Debug.Log("Start!");
        }
        else
        {
            Debug.Log("Stop!");
        }
	}

    private void setObjective()
    {
        newsText.text = "Sell some tacos!";
    }

    //
    //Functions for cost display UI
    
    //uses money to estimate total cost
    public void setCost(int cost)
    {
        monRemaining -= cost;
        setCostText(monRemaining, cost);
    }

    //Hides cost UI whenever buying is not active
    private void hideCost(bool inBasket)
    {
        if (inBasket == true)
        {
            costDisplay.SetActive(true);
        }
        else
        {
            costDisplay.SetActive(false);
        }
    }
    
    //Sets text in cost display UI to correct values
    private void setCostText(int money, float cost)
    {
        costText.text = "Total cost: " + cost.ToString();
        remainingMonText.text = "Remaining Money: " + money.ToString();
    }

    //use to update whenever changes are made → make global
    private void setPointText()
    {
        moneyText.text = "Money: " + money.ToString();
        greenText.text = "Green Points: " + greenPoints.ToString();
        popText.text = "Popularity: " + popularity.ToString();
    }

    //
    //Functions to be used when buying products to make tacos

    //Updates money & green points
    public void BuyProducts(int cost, int green)
    {
        money -= cost;
        greenPoints += green;//green should be positive or negative
        setPointText();
    }

    //Used when a customer receives their food
    //Updates money & customer popularity points
    public void ServeCustomer(int earn, int satisfaction)
    {
        money += earn;
        popularity += satisfaction;//make satis positive or negative based on likes/dislikes
        setPointText();
    }

    //Call when customer is in front of window
    private void customerTalks(string m)
    {
        message.text = m;
    }
}
