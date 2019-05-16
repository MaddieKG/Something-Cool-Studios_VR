using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleControl : MonoBehaviour {
    //attached to tutorial start button

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
        screen = GameObject.Find("titlescreen");
        titleCanvas = GameObject.Find("TitleDisplay");
        pointsDisplay = GameObject.Find("PointsScreen");
        //costDisplay = GameObject.Find("CostDisplay");
        newsDisplay = GameObject.Find("NewsDisplay");
        translator = GameObject.Find("Translator");
        sliders = GameObject.Find("Sliders");

        //s1 = GameObject.Find("s1").GetComponent<Text>();

        titleCanvas.SetActive(true);
        screen.SetActive(true);
        pointsDisplay.SetActive(false);
        UIcontrol.hideCost(true);
        newsDisplay.SetActive(false);
        translator.SetActive(false);
        sliders.SetActive(false);

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

            GameObject.Find("s1").GetComponent<Text>().enabled = true;
            GameObject.Find("step1").GetComponent<MeshRenderer>().enabled = true;

        }
    }

    public void setS1(bool set)
    {
        if (set == true)
        {
            GameObject.Find("s1").GetComponent<Text>().enabled = true;
            GameObject.Find("step1").GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            GameObject.Find("s1").GetComponent<Text>().enabled = false;
            GameObject.Find("step1").GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void setS2(bool set)
    {   
        if (set == true)
        {
            GameObject.Find("s2").GetComponent<Text>().enabled = true;
            GameObject.Find("step2").GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            GameObject.Find("s2").GetComponent<Text>().enabled = false;
            GameObject.Find("step2").GetComponent<MeshRenderer>().enabled = false;
        }
    }

    public void setS3(bool set)
    {
        if (set == true)
        {
            GameObject.Find("s3").GetComponent<Text>().enabled = true;
            GameObject.Find("step3").GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            GameObject.Find("s3").GetComponent<Text>().enabled = false;
            GameObject.Find("step3").GetComponent<MeshRenderer>().enabled = false;
        }
    }

}
