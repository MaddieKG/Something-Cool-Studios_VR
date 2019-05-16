using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
	}

    void Update ()
    {
        TitleControl titleControl = GameObject.Find("start").GetComponent<TitleControl>();
        if (titleControl.startData.start == true)
        {
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
