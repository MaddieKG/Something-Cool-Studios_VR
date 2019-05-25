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
        ready = false;
        buttonDisplay.text = "Buy";
    }

    private void OnTriggerEnter(Collider col)
    {
        UIcontrol = GameObject.Find("UIController");
        TutorialUIController controller = UIcontrol.GetComponent<TutorialUIController>();
        //addingToCart cartScript = GameObject.Find("cart").GetComponent<addingToCart>();


        start = true;
        if(col.gameObject.name == "RightHandAnchor" || col.gameObject.name == "LeftHandAnchor")
        {
            Debug.Log("Start: " + ready);
            if (ready == false)
            {
                buttonDisplay.text = "Buy";
            }
            else if (ready == true)
            {
                buttonDisplay.text = "...";
                controller.hideCost(start);
                controller.updateTranslator("Serve one taco");
            }
        }
    }
        

    public bool getStart()
    {
        return start;
    }
}
