using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeggieLover : MonoBehaviour {

    public string cname = "Jim";
    public string greens = "anti";
    public string meat = "pro";

    void Start()
    {
        Debug.Log("name: " + cname);
        Debug.Log("green: " + greens);
        Debug.Log("meat: " + meat);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
