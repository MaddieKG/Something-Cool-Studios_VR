using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tutorialEnd : MonoBehaviour {

    private GameObject screen, canvas;
    private Text text1, text2;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<MeshRenderer>().enabled = false;

        screen = GameObject.Find("titlescreen");
        canvas = GameObject.Find("TitleDisplay");
        text1 = GameObject.Find("Title").GetComponent<Text>();
        text2 = GameObject.Find("Sub").GetComponent<Text>();
	}

    void Update ()
    {
        TitleControl titleControl = GameObject.Find("start").GetComponent<TitleControl>();
        if (titleControl.startData.start == true)
        {
            text1.text = "Tutorial Complete!";
            text2.text = "Press the button to start the first round";
            canvas.SetActive(true);
            //text1.enabled = true;
            //text2.enabled = true;
            screen.SetActive(true);
            GetComponent<MeshRenderer>().enabled = true;
        }
    }
	
	void OnTriggerEnter(Collider col)
    {
        TitleControl titleControl = GameObject.Find("start").GetComponent<TitleControl>();
        if(col.gameObject.name == "RightHandAnchor" || col.gameObject.name == "LeftHandAnchor")
        {
            if (gameObject.GetComponent<MeshRenderer>().enabled == true)
            {
                SceneManager.LoadScene("main");
            }
        }
    }
}
