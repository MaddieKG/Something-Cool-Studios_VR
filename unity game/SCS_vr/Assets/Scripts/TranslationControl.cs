using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranslationControl : MonoBehaviour {

    public Text message;

	void Start () {
        message.text = "Waiting for input...";
	}
	
    //Call when customer is in front of window
    private void customerTalks(string m)
    {
        message.text = m;
    }
}
