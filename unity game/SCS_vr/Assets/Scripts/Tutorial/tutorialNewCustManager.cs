using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialNewCustManager : MonoBehaviour
{
    //array of game objects
    public GameObject[] allCust;
    private GameObject current;
    private GameObject position;
    public GameObject[] posArray;
    public string message;

    public GameObject UIcontrol, cartControl, tacoDetector;
    private int green, meat;

    void Start()
    {
        cartControl = GameObject.Find("cart");
        UIcontrol = GameObject.Find("UIController");
    }
    /*
    void SpawnCustomer()
    {
        //number of customers = 6
        for (int i = 0; i < 6; i++)
        {
            current = allCust[i];
            position = posArray[i];
            Instantiate(current, position.transform.position, transform.rotation);
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            //SpawnCustomer();
        }
    }

    void OnTriggerEnter()
    {
        //SpawnCustomer();
        tutorialAddingToCart cartScript = cartControl.GetComponent<tutorialAddingToCart>();
        UIcontrol = GameObject.Find("UIController");
        TutorialUIController controller = UIcontrol.GetComponent<TutorialUIController>();
        tacoDetector = GameObject.Find("plate");
        tutorialDetectTaco detectScript = tacoDetector.GetComponent<tutorialDetectTaco>();
        //get customer popularity
        //checks type of customer
        /*
        if (current.name == "courier" || current.name == "courierRotate(Clone)")
        {
            //nonorganic lover
            NonOrganicLover nonorgStats = current.GetComponent<NonOrganicLover>();
            green = nonorgStats.getGreens();
            meat = nonorgStats.getMeat();
        }
        else if (current.name == "shorthair" || current.name == "SHRotate(Clone")
        {
            //organic lover
            OrganicLover orgStats = current.GetComponent<OrganicLover>();
            green = orgStats.getGreens();
            meat = orgStats.getMeat();
        }
        else if (current.name == "baldsuit" || current.name == "BSRotate(Clone)")
        {
            //chicken lover
            ChickenLover orgStats = current.GetComponent<ChickenLover>();
            green = orgStats.getGreens();
            meat = orgStats.getMeat();
        }
        else if (current.name == "security" || current.name == "SecRotate(Clone)")
        {
            //Generic cust (random preferences)
            GenericCust orgStats = current.GetComponent<GenericCust>();
            green = orgStats.getGreens();
            meat = orgStats.getMeat();
        }
        else if (current.name == "pony" || current.name == "ponyRotate(Clone)")
        {
            //Generic cust (random preferences)
            GenericCust orgStats = current.GetComponent<GenericCust>();
            green = orgStats.getGreens();
            meat = orgStats.getMeat();
        }
        else if (current.name == "longhair" || current.name == "LHRotate(Clone)")
        {
            //cheap lover
            CheapLover orgStats = current.GetComponent<CheapLover>();
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
        else if ((cartScript.currentLettuce != green && cartScript.currentMeat != meat) || current.name == "longhair")
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
        else if (current.name == "security" || current.name == "pony")
        {
            message = "Thank you!";
            detectScript.tacoPop = 2;
        }
        else
        {
            message = "Thank you!";
            detectScript.tacoPop = 2;
        }*/
        controller.updateTranslator(message);
    }
}
