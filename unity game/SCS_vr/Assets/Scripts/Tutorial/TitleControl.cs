using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleControl : MonoBehaviour {
    //attached to tutorial start button

    [SerializeField]
    public StartData startData;
    private GameObject titleCanvas;
    private GameObject pointsDisplay, costDisplay, newsDisplay, translator, screen, sliders;
    private GameObject step1, step2, step3;
    //private Text s1, s2, s3;
    private bool tutorialStart, s1Status, s2Status, s3Status;

	// Use this for initialization
	void Start () {

        TutorialUIController UIcontrol = GameObject.Find("UIController").GetComponent<TutorialUIController>();
        setStart(false);

        screen = GameObject.Find("titlescreen");
        titleCanvas = GameObject.Find("TitleDisplay");
        pointsDisplay = GameObject.Find("PointsScreen");
        //costDisplay = GameObject.Find("CostDisplay");
        //newsDisplay = GameObject.Find("NewsDisplay");
        translator = GameObject.Find("Translator");
        sliders = GameObject.Find("Sliders");

        step1 = GameObject.Find("step1");
        step2 = GameObject.Find("step2");
        step3 = GameObject.Find("step3");

        //s1 = GameObject.Find("s1").GetComponent<Text>();
        titleCanvas.SetActive(true);
        pointsDisplay.SetActive(false);
        UIcontrol.hideCost(true);
        //newsDisplay.SetActive(false);
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
            //newsDisplay.SetActive(true);
            translator.SetActive(true);
            sliders.SetActive(true);

            GameObject.Find("logo").GetComponent<MeshRenderer>().enabled = false ;

            tutorialStart = true;

            setS1(true);

        }
    }

    public void setS1(bool set)
    {
        //GameObject.Find("s1").GetComponent<Text>().enabled = set;
        //GameObject.Find("step1").GetComponent<MeshRenderer>().enabled = set;
        step1.SetActive(set);
        s1Status = set;
        
    }

    public void setS2(bool set)
    {
        //GameObject.Find("s2").GetComponent<Text>().enabled = set;
        //GameObject.Find("step2").GetComponent<MeshRenderer>().enabled = set;
        step2.SetActive(set);
        s2Status = set;
    }
    public void setS3(bool set)
    {
        //GameObject.Find("s3").GetComponent<Text>().enabled = set;
        //GameObject.Find("step3").GetComponent<MeshRenderer>().enabled = set;
        step3.SetActive(set);
        s3Status = set;
    }

    public void setStart(bool status)
    {
        startData.start = status;
    }

    public bool getS1Status()
    {
        return s1Status;
    }

    public bool getS2Status()
    {
        return s2Status;
    }

    public bool getS3Status()
    {
        return s3Status;
    }

}
