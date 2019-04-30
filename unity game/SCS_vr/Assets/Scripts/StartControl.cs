using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartControl : MonoBehaviour {

    public bool start;
    public Text buttonDisplay;
	//object this is attached to needs a RigidBody
    //please attach to a StartButton object

	void Start () {
        start = false;
        buttonDisplay.text = "Start";
    }

    private void OnTriggerEnter()
    {
        start = !start;
        if (start == false)
        {
            buttonDisplay.text = "Start";
        }
        else
        {
            buttonDisplay.text = "Stop";
        }
    }

    public bool getStart()
    {
        return start;
    }
}
