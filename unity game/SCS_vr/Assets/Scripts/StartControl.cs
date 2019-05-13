using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartControl : MonoBehaviour {

    public bool start, ready;
    public Text buttonDisplay;

    private GameObject UIcontrol, cartControl;
    //object this is attached to needs a RigidBody
    //please attach to a StartButton object

    void Start () {
        start = false;
        buttonDisplay.text = "Start";
    }

    private void OnTriggerEnter()
    {
        UIcontrol = GameObject.Find("UIController");
        UIController controller = UIcontrol.GetComponent<UIController>();
        //addingToCart cartScript = GameObject.Find("cart").GetComponent<addingToCart>();


        start = true;
        if (start == false)
        {
            buttonDisplay.text = "Start";
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
