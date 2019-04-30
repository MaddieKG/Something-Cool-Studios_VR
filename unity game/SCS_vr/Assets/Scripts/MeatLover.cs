using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatLover : MonoBehaviour {

    public string cname = "Bob";
    public string greens = "pro";
    public string meat = "anti";

	void Start () {
        Debug.Log("name: " + cname);
        Debug.Log("green: " + greens);
        Debug.Log("meat: " + meat);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
