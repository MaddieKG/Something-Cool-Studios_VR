using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleControl : MonoBehaviour {

    [SerializeField]
    private StartData startData;
    private GameObject titleCanvas;
    private GameObject pointsDisplay, costDisplay, newsDisplay, translator, screen, sliders;
    private Text s1, s2, s3;
    private bool tutorialStart;

	// Use this for initialization
	void Start () {

        TutorialUIController UIcontrol = GameObject.Find("UIController").GetComponent<TutorialUIController>();

        startData.start = false;
        titleCanvas = GameObject.Find("TitleDisplay");/*
        pointsDisplay = GameObject.Find("PointsScreen");
        costDisplay = GameObject.Find("CostDisplay");
        newsDisplay = GameObject.Find("NewsDisplay");
        translator = GameObject.Find("Translator");
        screen = GameObject.Find("titlescreen");
        sliders = GameObject.Find("Sliders");*/

        //s1 = GameObject.Find("s1").GetComponent<Text>();

        titleCanvas.SetActive(true);
        screen.SetActive(true);/*
        pointsDisplay.SetActive(false);
        costDisplay.SetActive(false);
        newsDisplay.SetActive(false);
        translator.SetActive(false);
        sliders.SetActive(false);*/

        //UI setup
        GameObject.Find("s1").GetComponent<Text>().enabled = false;
        GameObject.Find("s2").GetComponent<Text>().enabled = false;
        GameObject.Find("s3").GetComponent<Text>().enabled = false;

        //screen setup
        GameObject.Find("step1").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("step2").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("step3").GetComponent<MeshRenderer>().enabled = false;
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
            titleCanvas.SetActive(false);/*
            pointsDisplay.SetActive(true);
            costDisplay.SetActive(true);
            newsDisplay.SetActive(true);
            translator.SetActive(true);
            sliders.SetActive(true);*/
            tutorialStart = true;

            GameObject.Find("s1").GetComponent<Text>().enabled = true;
            GameObject.Find("step1").GetComponent<MeshRenderer>().enabled = true;
        }
    }


}
