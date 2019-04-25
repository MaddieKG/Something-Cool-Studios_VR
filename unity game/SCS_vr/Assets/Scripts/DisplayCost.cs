using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCost : MonoBehaviour {

    private GameObject costDisplay;
    private bool isShowing;
    public Text costText, remainingMonText;
    private GameObject controller;
    private float monRemaining, cost;

	// Use this for initialization
	void Start () {
        controller = GameObject.Find("GameController");
        costDisplay = GameObject.Find("CostDisplay");
        PointsControl controlScript = controller.GetComponent<PointsControl>();

        costDisplay.SetActive(true);
        monRemaining = controlScript.money;
        cost = 0;
        SetText(monRemaining, cost);
    }
	

    public void SetCost (float cost) {
        monRemaining -= cost;
        SetText(monRemaining, cost);
    }

    private void HideCost (bool inBasket)
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

    private void SetText(float money, float cost)
    {
        costText.text = "Total cost: " + cost.ToString();
        remainingMonText.text = "Remaining Money: " + money.ToString();
    }
}
