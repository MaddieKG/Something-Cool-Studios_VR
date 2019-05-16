﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleControl : MonoBehaviour {
    //attached to tutorial start button

    [SerializeField]
    public StartData startData;
    private GameObject titleCanvas;
    private GameObject pointsDisplay, costDisplay, newsDisplay, translator, screen, sliders;
    private Text s1, s2, s3;
    private bool tutorialStart;

	// Use this for initialization
	void Start () {

        TutorialUIController UIcontrol = GameObject.Find("UIController").GetComponent<TutorialUIController>();
        setStart(false);
        screen = GameObject.Find("titlescreen");
        titleCanvas = GameObject.Find("TitleDisplay");
        pointsDisplay = GameObject.Find("PointsScreen");
        //costDisplay = GameObject.Find("CostDisplay");
        newsDisplay = GameObject.Find("NewsDisplay");
        translator = GameObject.Find("Translator");
        sliders = GameObject.Find("Sliders");

        //s1 = GameObject.Find("s1").GetComponent<Text>();

        titleCanvas.SetActive(true);
        pointsDisplay.SetActive(false);
        UIcontrol.hideCost(true);
        newsDisplay.SetActive(false);
        translator.SetActive(false);
        sliders.SetActive(false);

        //UI setup
        setS1(false);
        setS2(false);
        setS3(false);
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider col)
    {
        TutorialUIController UIcontrol = GameObject.Find("UIController").GetComponent<TutorialUIController>();
        if (col.gameObject.name == "RightHandAnchor" || col.gameObject.name == "LeftHandAnchor")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            //gameObject.SetActive(false);
            screen.SetActive(false);
            titleCanvas.SetActive(false);
            pointsDisplay.SetActive(true);
            UIcontrol.hideCost(false);
            newsDisplay.SetActive(true);
            translator.SetActive(true);
            sliders.SetActive(true);
            tutorialStart = true;

            setS1(true);

        }
    }

    public void setS1(bool set)
    {
            GameObject.Find("s1").GetComponent<Text>().enabled = set;
            GameObject.Find("step1").GetComponent<MeshRenderer>().enabled = set;
        
    }

    public void setS2(bool set)
    {
        GameObject.Find("s2").GetComponent<Text>().enabled = set;
        GameObject.Find("step2").GetComponent<MeshRenderer>().enabled = set;
    }

    public void setS3(bool set)
    {
            GameObject.Find("s3").GetComponent<Text>().enabled = set;
            GameObject.Find("step3").GetComponent<MeshRenderer>().enabled = set;
    }

    public void setStart(bool status)
    {
        Debug.Log(status);
        startData.start = status;
    }
}
