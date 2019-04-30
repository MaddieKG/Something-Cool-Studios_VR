using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerManager : MonoBehaviour {
    //array of game objects
    public GameObject[] allCust;
    public GameObject current;
    public GameObject pos;

    public GameObject UIcontrol;

    void Start()
    {
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
            Debug.Log(current.name);
        }
	}
    
    void OnTriggerEnter()
    {
        SpawnCustomer();
        bool likes = true;
        UIcontrol = GameObject.Find("UIController");
        UIController controller = UIcontrol.GetComponent<UIController>();
        controller.updateTranslator(likes);
    }
}
