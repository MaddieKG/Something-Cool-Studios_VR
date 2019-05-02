using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public Text newsText;
    public Text costText, remainingMonText;
    public Text moneyText, popText, greenText;
    public Text message;

    [SerializeField]
    private PointsData pointsData;
    private bool isCostShowing;
    private GameObject costDisplay, startButton;
    private int monRemaining, cost;

    // Use this for initialization
    void Start () {
        //Allows for initialization
        startButton = GameObject.Find("StartButton");//need a StartButton object
        StartControl startScript = startButton.GetComponent<StartControl>();
        startScript.start = false;

        //cost display stuff
        costDisplay = GameObject.Find("CostDisplay");
        costDisplay.SetActive(true);
        monRemaining = pointsData.Money;
        cost = 0;

        //For translator
        message.text = "Waiting for input...";

        //sets all text
        setObjective();
        setCostText(cost);
        setPointText();
    }

    private void setObjective()
    {
        newsText.text = "Sell some tacos!";
    }
    
    //uses money to estimate total cost
    public void setCost(int cost)
    {
        monRemaining -= cost;
        setCostText(cost);
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
    public void setCostText(int cost)
    {
        costText.text = "Total cost: " + cost.ToString();
        monRemaining = pointsData.Money - cost;
        remainingMonText.text = "Remaining Money: " + monRemaining.ToString();
    }

    //use to update whenever changes are made → make global
    public void setPointText()
    {
        moneyText.text = "Money: " + pointsData.Money.ToString();
        greenText.text = "Green Points: " + pointsData.Green.ToString();
        popText.text = "Popularity: " + pointsData.Popularity.ToString();
    }

    public void updateTranslator(bool likes)
    {
        if (likes == true)
        {
            message.text = ":)";
        }
        else
        {
            message.text = ":(";
        }
    }
    
}
