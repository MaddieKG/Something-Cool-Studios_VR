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
    private GameObject costDisplay, startButton, pointsController, translatorSound;
    private float monRemaining, cost;

    // Use this for initialization
    void Start () {
        //Allows for initialization
        startButton = GameObject.Find("StartButton");//need a StartButton object
        StartControl startScript = startButton.GetComponent<StartControl>();
        startScript.start = false;
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();

        //cost display stuff
        costDisplay = GameObject.Find("CostDisplay");
        //costDisplay.SetActive(true);
        monRemaining = pointsScript.pointsData.Money;
        cost = 0;

        //For translator
        message.text = "Waiting for input...";
        translatorSound = GameObject.Find("TranslatorSound");
        translatorSound.SetActive(false);

        //sets all text
        //setObjective("");
        setCostText(cost);
        setPointText();
    }

    public void setObjective(string obj)
    {
        //newsText.text = obj;//"Sell some tacos!";
    }
    
    //uses money to estimate total cost
    public void setCost(float cost)
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
    public void setCostText(float cost)
    {
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        costText.text = "Total cost: " + cost.ToString("0.##");
        monRemaining = pointsScript.pointsData.money - cost;
        remainingMonText.text = "Remaining Money: " + monRemaining.ToString();
    }

    //use to update whenever changes are made → make global
    public void setPointText()
    {
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        moneyText.text = "Money: ";// + pointsScript.pointsData.money.ToString();
        greenText.text = "Green: ";// + pointsScript.pointsData.green.ToString();
        popText.text = "Popularity: ";// + pointsScript.pointsData.popularity.ToString();
    }

    public void updateTranslator(string m)
    {
        message.text = m;
        StartCoroutine(playSound());
    }

    IEnumerator playSound()
    {
        translatorSound.SetActive(true);
        yield return new WaitForSeconds(1);
        translatorSound.SetActive(false);
    }
    
}
