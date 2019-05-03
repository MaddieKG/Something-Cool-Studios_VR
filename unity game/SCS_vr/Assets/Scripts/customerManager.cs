using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerManager : MonoBehaviour {
    //array of game objects
    public GameObject[] allCust;
    public GameObject current;
    public GameObject pos;

    public GameObject UIcontrol, cartControl;

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
        if(current.name == "courier")
        {
            //"meat lover"
        }
        else if(current.name == "shorthair")
        {
            //"veggie lover"
        }
        addingToCart cartScript = cartControl.GetComponent<addingToCart>();
        UIcontrol = GameObject.Find("UIController");
        UIController controller = UIcontrol.GetComponent<UIController>();
        /**if (cartScript.currentLettuce == current.getGreens() && cartScript.currentMeat == current.getMeat())
        {
            controller.updateTranslator(true);
        }**/
    }
}
