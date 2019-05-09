using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerManager : MonoBehaviour {
    //array of game objects
    public GameObject[] allCust;
    public static GameObject current;
    public GameObject[] pos;
    public string message;

    public GameObject UIcontrol, cartControl, tacoDetector;
    private int green, meat;

    void Start()
    {
        cartControl = GameObject.Find("cart");
        UIcontrol = GameObject.Find("UIController");
    }

    void SpawnCustomer()
    {
        //allCust size is 6
        int p = 0;
        for (int i = 0; i < 6; i++)
         {
          current = allCust[i];
          Instantiate(current, pos[p].transform.position, transform.rotation);
          p++;
        }
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
            SpawnCustomer();
        }
	}

    void OnTriggerEnter()
    {
        SpawnCustomer();
        addingToCart cartScript = cartControl.GetComponent<addingToCart>();
        UIcontrol = GameObject.Find("UIController");
        UIController controller = UIcontrol.GetComponent<UIController>();
        tacoDetector = GameObject.Find("counter");
        detectTaco detectScript = tacoDetector.GetComponent<detectTaco>();
        //get customer popularity
        //checks type of customer
        if (current.name == "courier")
        {
            //nonorganic lover
            NonOrganicLover nonorgStats = current.GetComponent<NonOrganicLover>();
            green = nonorgStats.getGreens();
            meat = nonorgStats.getMeat();
        }
        else if (current.name == "shorthair")
        {
            //organic lover
            OrganicLover orgStats = current.GetComponent<OrganicLover>();
            green = orgStats.getGreens();
            meat = orgStats.getMeat();
        }
        //generates response
        if (cartScript.currentLettuce == green && cartScript.currentMeat == meat)
        {
            message = "I love the tacos!";
            detectScript.tacoPop = 3;
        }
        else if ((cartScript.currentLettuce != green || cartScript.currentMeat != meat) && current.name == "shorthair")
        {
            message = "The tacos aren't environmentally friendly enough.";
            detectScript.tacoPop = -3;
        }
        else if (cartScript.currentLettuce != green && cartScript.currentMeat != meat)
        {
            if (green == 0 && meat == 1)
            {
                message = "The tacos are too expensive.";
                detectScript.tacoPop = -1;
            }
        }

        else if (cartScript.currentMeat != meat)
        {
            if (meat == 0)
            {
                message = "I wish the tacos had beef.";
                detectScript.tacoPop = -2;
            }
            else if (meat == 1)
            {
                message = "I wish the tacos had chicken.";
                detectScript.tacoPop = -1;
            }
        }
        else
        {
            message = "Thank you!";
            detectScript.tacoPop = 2;
        }
        controller.updateTranslator(message);
    }
}
