using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleControl : MonoBehaviour {

    [SerializeField]
    private StartData startData;
    private GameObject titleCanvas;
    private GameObject pointsDisplay, costDisplay, newsDisplay, translator, screen;
    private bool tutorialStart;

	// Use this for initialization
	void Start () {
        startData.start = false;
        titleCanvas = GameObject.Find("TitleDisplay");
        pointsDisplay = GameObject.Find("PointsScreen");
        costDisplay = GameObject.Find("CostDisplay");
        newsDisplay = GameObject.Find("NewsDisplay");
        translator = GameObject.Find("Translator");
        screen = GameObject.Find("titlescreen");
        
        titleCanvas.SetActive(true);
        screen.SetActive(true);
        pointsDisplay.SetActive(false);
        costDisplay.SetActive(false);
        newsDisplay.SetActive(false);
        translator.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "RightHandAnchor" || col.gameObject.name == "LeftHandAnchor")
        {
            gameObject.SetActive(false);
            screen.SetActive(false);
            titleCanvas.SetActive(false);
            pointsDisplay.SetActive(true);
            costDisplay.SetActive(true);
            newsDisplay.SetActive(true);
            translator.SetActive(true);
            tutorialStart = true;
        }
    }


}
