using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialCustomerManager : MonoBehaviour
{
    //array of game objects
    public GameObject[] allCust;
    public GameObject current;
    public GameObject position;
    public GameObject[] posArray;
    public string message;

    private int green, meat;

    void SpawnCustomer()
    {
        /*
          int i = Random.Range(0, allCust.Length);
          current = allCust[i];
          Instantiate(current, pos.transform.position, transform.rotation);

          current.transform.Rotate(0, 90, 0);
          */

        //number of customers = 6
        for (int i = 0; i < 1; i++)
        {
            current = allCust[i];
            Debug.Log("index: " + i);
            position = posArray[i];
            Instantiate(current, position.transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SpawnCustomer();
        }
    }

    void OnTriggerEnter()
    {
        tutorialStartControl startScript = GameObject.Find("StartButton").GetComponent<tutorialStartControl>();
        TitleControl titleControl = GameObject.Find("start").GetComponent<TitleControl>();
        TutorialUIController controller = GameObject.Find("UIController").GetComponent<TutorialUIController>();

        titleControl.setS2(false);
        titleControl.setS3(true);

        if (startScript.ready == true)
        {
            Debug.Log("customer spawned");
            SpawnCustomer();
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
                Debug.Log("shorthair");
                OrganicLover orgStats = current.GetComponent<OrganicLover>();
                green = orgStats.getGreens();
                meat = orgStats.getMeat();
            }
            //generates response
            message = "Serve one taco";//getResponse(meat, green);
            controller.updateTranslator(message);
        }
    }
    /*
    private string getResponse(int m, int g)
    {
        tutorialAddingToCart cartScript = GameObject.Find("cart").GetComponent<tutorialAddingToCart>();
        tutorialDetectTaco detectScript = GameObject.Find("counter").GetComponent<tutorialDetectTaco>();
        string response = null;

        if (cartScript.currentLettuce == green && cartScript.currentMeat == meat)
        {
            response = "I love the tacos!";
            detectScript.tacoPop = 3;
        }
        else if ((cartScript.currentLettuce != green || cartScript.currentMeat != meat) && current.name == "shorthair")
        {
            response = "The tacos aren't sustainable enough.";
            detectScript.tacoPop = -3;
        }
        /*
        else if (cartScript.currentLettuce != green && cartScript.currentMeat != meat)
        {
            if (green == 0 && meat == 1)
            {
                response = "The tacos are too expensive.";
                detectScript.tacoPop = -1;
            }
        }
        
        else if (cartScript.currentMeat != meat)
        {
            if (meat == 0)
            {
                response = "I wish the tacos had beef.";
                detectScript.tacoPop = -2;
            }
            else if (meat == 1)
            {
                response = "I wish the tacos had chicken.";
                detectScript.tacoPop = -1;
            }
        }
        else
        {
            response = "Thank you!";
            detectScript.tacoPop = 2;
        }
        return response;
    }*/
}
