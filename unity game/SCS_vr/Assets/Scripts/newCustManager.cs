using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCustManager : MonoBehaviour
{
    //array of game objects
    public GameObject[] allCust;
    private GameObject current;
    private GameObject position;
    public GameObject[] posArray;
    public string message;
    //private Animator anim;

    public GameObject UIcontrol, cartControl, tacoDetector;
    private int green, meat;

    void Start()
    {
        cartControl = GameObject.Find("cart");
        UIcontrol = GameObject.Find("UIController");
    }

    void SpawnCustomer()
    {
        //number of customers = 6
        for (int i = 0; i < 6; i++)
        {
            current = allCust[i];
            position = posArray[i];
            Instantiate(current, position.transform.position, transform.rotation);
        }
    }

    void OnTriggerEnter()
    {
      StartControl startScript = GameObject.Find("StartButton").GetComponent<StartControl>();
      if (startScript.ready == true)
      {
        SpawnCustomer();
        foreach(GameObject cust in allCust)
        {
          Debug.Log(cust.gameObject.tag);
          if(cust.gameObject.tag == "chicken")
          {
            ChickenLover chickl = current.GetComponent<ChickenLover>();
            chickl.startIdile();
          }
          else if(cust.gameObject.tag == "nonorganic")
          {
            NonOrganicLover nl = current.GetComponent<NonOrganicLover>();
            nl.startIdile();
          }
          else if(cust.gameObject.tag == "cheap")
          {
            CheapLover cheapl = current.GetComponent<CheapLover>();
            cheapl.startIdile();
          }
          else if(cust.gameObject.tag == "generic")
          {
            GenericCust gl = current.GetComponent<GenericCust>();
            gl.startIdile();
          }
          else if(cust.gameObject.tag == "organic")
          {
            OrganicLover ol = current.GetComponent<OrganicLover>();
            ol.startIdile();
          }
        }
        addingToCart cartScript = cartControl.GetComponent<addingToCart>();
        UIcontrol = GameObject.Find("UIController");
        UIController controller = UIcontrol.GetComponent<UIController>();
        tacoDetector = GameObject.Find("plate");
        detectTaco detectScript = tacoDetector.GetComponent<detectTaco>();
      }
        //get customer popularity
        //checks type of customer
        /*
        if (current.name == "courier" || current.name == "courierRotate")
        {
            //nonorganic lover
            NonOrganicLover nonorgStats = current.GetComponent<NonOrganicLover>();
            green = nonorgStats.getGreens();
            meat = nonorgStats.getMeat();
        }
        else if (current.name == "shorthair" || current.name == "SHRotate")
        {
            //organic lover
            OrganicLover orgStats = current.GetComponent<OrganicLover>();
            green = orgStats.getGreens();
            meat = orgStats.getMeat();
        }
        else if (current.name == "baldsuit" || current.name == "BSRotate")
        {
            //chicken lover
            ChickenLover orgStats = current.GetComponent<ChickenLover>();
            green = orgStats.getGreens();
            meat = orgStats.getMeat();
        }
        else if (current.name == "security" || current.name == "SecRotate")
        {
            //Generic cust (random preferences)
            GenericCust orgStats = current.GetComponent<GenericCust>();
            green = orgStats.getGreens();
            meat = orgStats.getMeat();
        }
        else if (current.name == "pony" || current.name == "ponyRotate")
        {
            //Generic cust (random preferences)
            GenericCust orgStats = current.GetComponent<GenericCust>();
            green = orgStats.getGreens();
            meat = orgStats.getMeat();
        }
        else if (current.name == "longhair" || current.name == "LHRotate")
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
        else if(current.name == "security" || current.name == "pony")
        {
            message = "Thank you!";
            detectScript.tacoPop = 2;
        }
        else
        {
            message = "Thank you!";
            detectScript.tacoPop = 2;
        }
        controller.updateTranslator(message);
        */
    }
}
