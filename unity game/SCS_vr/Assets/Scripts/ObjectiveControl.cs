using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveControl : MonoBehaviour {

    public Text objectiveText;
    private string objective; 
    
    void Start () {
        objective = "Sell tacos!";
        SetText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void SetText()
    {
        string currentArticle = objective;
        objectiveText.text = currentArticle;
    }
}
