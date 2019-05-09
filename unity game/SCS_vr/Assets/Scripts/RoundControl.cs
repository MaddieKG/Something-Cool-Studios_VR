﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RoundControl : MonoBehaviour
{

    //please attach to a EndButton object

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    void Update()
    {
        StartControl startScript = GameObject.Find("StartButton").GetComponent<StartControl>();

        if (startScript.start == true)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }

    private void OnTriggerEnter()
    {
        SceneManager.LoadScene("main");
    }
}
