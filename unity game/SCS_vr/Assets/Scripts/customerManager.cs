using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerManager : MonoBehaviour {
    //array of game objects
    public GameObject[] allCust;
    private GameObject current;
    public GameObject pos;

    void SpawnCustomer()
    {
        int i = Random.Range(0, allCust.Length);
        current = allCust[i];
        Instantiate(current, pos.transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("space"))
        {
            SpawnCustomer();
            Debug.Log(current.name);
        }
	}
}
