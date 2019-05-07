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
    private GameObject costDisplay, startButton, pointsController;
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
    public void hideCost(bool start)
    {
        if (start == false)
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
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        costText.text = "Total cost: " + cost.ToString();
        monRemaining = pointsScript.money - cost;
        remainingMonText.text = "Remaining Money: " + monRemaining.ToString();
    }

    //use to update whenever changes are made → make global
    public void setPointText()
    {
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        moneyText.text = "Money: " + pointsScript.money.ToString();
        greenText.text = "Green Points: " + pointsScript.green.ToString();
        popText.text = "Popularity: " + pointsScript.popularity.ToString();
    }

    public void updateTranslator(string m)
    {
        message.text = m;
        ///yield return new WaitForSeconds(3);
        //message.text = "Waiting for input...";
    }
    
}
