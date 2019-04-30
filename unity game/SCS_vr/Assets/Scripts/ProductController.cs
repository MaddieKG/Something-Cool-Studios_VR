using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductController : MonoBehaviour {
    public int money, green;
    private GameObject startButton;
    //private RigidBody rb;

    // Use this for initialization
    void Start() {
        //rb = gameObject.GetComponent<RigidBody>();
	}
	
	// Update is called once per frame
	void Update () {
        startButton = GameObject.Find("StartButton");//need a StartButton object
        StartControl startScript = startButton.GetComponent<StartControl>();
        if (startScript.start == true)
        {
            Destroy(gameObject.GetComponent<Rigidbody>());
            //rb.detectCollisions = false;
        }
        else
        {
            gameObject.AddComponent<Rigidbody>();
            //rb.detectCollisions = true;
        }
    }
}
