using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newCustManager : MonoBehaviour
{
    //array of game objects
    public GameObject[] allCust, posArray;
    public GameObject current, position, cust;
    //public string message;
    //private Animator anim;
    //public GameObject UIcontrol;
    public GameObject cartControl, tacoDetector;
    private int green, meat;

    void Start()
    {
        cartControl = GameObject.Find("cart");
        //UIcontrol = GameObject.Find("UIController");
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
      }
        for(int j = 0; j < 6; j++) {
            cust = allCust[j];
            Debug.Log(cust.gameObject.name);

        }
        addingToCart cartScript = cartControl.GetComponent<addingToCart>();
        //UIcontrol = GameObject.Find("UIController");
        //UIController controller = UIcontrol.GetComponent<UIController>();
        tacoDetector = GameObject.Find("plate");
        detectTaco detectScript = tacoDetector.GetComponent<detectTaco>();
    }
}
