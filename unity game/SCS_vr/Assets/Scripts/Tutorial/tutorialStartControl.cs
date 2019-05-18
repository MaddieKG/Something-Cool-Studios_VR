using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialStartControl : MonoBehaviour
{

    public bool start, ready;
    public Text buttonDisplay;

    private GameObject UIcontrol, cartControl;
    //object this is attached to needs a RigidBody
    //please attach to a StartButton object

    void Start()
    {
        start = false;
        buttonDisplay.text = "Buy";
    }

    private void OnTriggerEnter()
    {
        UIcontrol = GameObject.Find("UIController");
        TutorialUIController controller = UIcontrol.GetComponent<TutorialUIController>();
        //addingToCart cartScript = GameObject.Find("cart").GetComponent<addingToCart>();


        start = true;
        if (start == false)
        {
            buttonDisplay.text = "Buy";
            controller.hideCost(start);
        }
        else if (ready == true)
        {
            buttonDisplay.text = "...";
            controller.hideCost(start);
        }
    }

    public bool getStart()
    {
        return start;
    }
}
