using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerManager : MonoBehaviour {
    //array of game objects
    public GameObject[] allCust;
    private GameObject current;
    public GameObject[] pos;

    public GameObject UIcontrol, cartControl;

    void Start()
    {
        cartControl = GameObject.Find("cart");
        UIcontrol = GameObject.Find("UIController");
    }

    void SpawnCustomer()
    {
      /*
        int i = Random.Range(0, allCust.Length);
        current = allCust[i];
        Instantiate(current, pos.transform.position, transform.rotation);

        current.transform.Rotate(0, 90, 0);
        */
        //allCust size is 6
        int p = 0;
        for (int i = 0; i < 6; i++)
         {
          //Creates instance of prefab at current spawn pt
          current = allCust[i];
          Instantiate(current, pos[p].transform.position, transform.rotation);
          current.transform.Rotate(180, 0, 0);

          //Moves to the next spawn point index. Will wrap if it goes out of range
          p++;
        }
    }

    void moveUp()
    {
      int p = 0;
      for(int i = 0; i < 6; i++)
      {
        current = allCust[i];
        if(p == 0)
        {
          Destroy(current);
        }
        else
        {
          Destroy(current);
          Instantiate(current, pos[p].transform.position, transform.rotation);
          current.transform.Rotate(180, 0, 0);
          p++;
        }
      }
    }
    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown("space"))
        {
            SpawnCustomer();
            Debug.Log("space pressed");
        }
        if(Input.GetKeyDown(KeyCode.Backspace))
        {
          Debug.Log("Backspace pressed");
          moveUp();
        }
	}

    void OnTriggerEnter()
    {
        SpawnCustomer();
        addingToCart cartScript = cartControl.GetComponent<addingToCart>();
        UIcontrol = GameObject.Find("UIController");
        UIController controller = UIcontrol.GetComponent<UIController>();
        if (cartScript.currentLettuce == "pro" && cartScript.currentMeat == "pro")
        {
            controller.updateTranslator(true);
        }
    }
}
