using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCost : MonoBehaviour {

    public Canvas costDisplay;
    private bool isShowing;
    public Text costText

	// Use this for initialization
	void Start () { 
        costDisplay = GetComponent<Canvas> ();
        isShowing = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isShowing == true)
        {
            costDisplay.enabled = true;
            //may need to change costDisplay.enabled to costDisplay.SetActive(isShowing)
        }
        else
        {
            costDisplay.enabled = false;
        }
	}

    public void setCost (float cost) {
        costText.text = "Total cost: " + cost.ToString();
    }
}
