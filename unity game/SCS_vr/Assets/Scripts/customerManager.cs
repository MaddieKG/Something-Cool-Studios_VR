using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerManager : MonoBehaviour {
    //array of game objects
    public GameObject[] allCust;
    public GameObject current;
    public GameObject pos;
    public string message;

    public GameObject UIcontrol, cartControl;
    private int green, meat;

    void Start()
    {
        cartControl = GameObject.Find("cart");
        UIcontrol = GameObject.Find("UIController");
    }

    void SpawnCustomer()
    {
        int i = Random.Range(0, allCust.Length);
        current = allCust[i];
        Instantiate(current, pos.transform.position, transform.rotation);

        current.transform.Rotate(0, 90, 0);
    }

    // Update is called once per frame
    void Update () {
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
        //checks what type of customer
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
        }
        else if (cartScript.currentLettuce == 1)
        {
            message = "The tacos are too expensive";
        }
        else if (cartScript.currentMeat == 1)
        {
            message = "I wish the tacos had beef";
        }
        else
        {
            message = "The tacos are not environmentally friendly!";

        }
        controller.updateTranslator(message);
    }
}
