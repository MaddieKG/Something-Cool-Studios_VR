using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsControl : MonoBehaviour {

    private GameObject tip1, tip2, tip3;

	// Use this for initialization
	void Start () {
        tip1 = GameObject.Find("Tip1");
        tip2 = GameObject.Find("Tip2");
        tip3 = GameObject.Find("Tip3");

        setTip1(false);
        setTip2(false);
        setTip3(false);
	}
	
	// Update is called once per frame
	void Update () {
        TitleControl titleControl = GameObject.Find("start").GetComponent<TitleControl>();
        TutorialUIController controller = GameObject.Find("UIController").GetComponent<TutorialUIController>();
        if (titleControl.getS1Status() == true)
        {
            setTip1(true);
        }
        else if (titleControl.getS2Status() == true)
        {
            setTip1(false);
            setTip2(true);
            setTip3(true);
            controller.updateTranslator("Serve one taco");
        }
        else if (titleControl.getS3Status() == true)
        {
            setTip2(false);
            setTip3(false);
        }
    }

    private void setTip1(bool set)
    {
        tip1.SetActive(set);
    }

    private void setTip2(bool set)
    {
        tip2.SetActive(set);
    }

    private void setTip3(bool set)
    {
        tip3.SetActive(set);
    }
}
