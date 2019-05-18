using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsControl : MonoBehaviour {
    private GameObject s1Lights, s2Lights, s3Lights;

	// Use this for initialization
	void Start () {
        s1Lights = GameObject.Find("step1Lights");
        s2Lights = GameObject.Find("step2Lights");
        s3Lights = GameObject.Find("step3Lights");

        //s1Lights.SetActive(false);
        //s2Lights.SetActive(false);
        //s3Lights.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        TitleControl titleControl = GameObject.Find("start").GetComponent<TitleControl>();
        if (titleControl.getS1Status() == true)
        {
            s1Lights.SetActive(true);
            Debug.Log("s1 true");
        }
        else
        {
            s1Lights.SetActive(false);
        } 
        if (titleControl.getS2Status() == true)
        {
            s2Lights.SetActive(true);
        }
        else
        {
            s2Lights.SetActive(false);
        }
        if (titleControl.getS3Status() == true)
        {
            s3Lights.SetActive(true);
        }
        else
        {
            s3Lights.SetActive(false);
        }
	}
}
