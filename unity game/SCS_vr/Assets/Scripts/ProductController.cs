using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductController : MonoBehaviour {
    [SerializeField]
    public PointsData pointsData;

    public int money, green;
    private GameObject startButton, controller;
    //private RigidBody rb;

    // Use this for initialization
    void Start() {
        controller = GameObject.Find("UIController");
        UIController controlUI = controller.GetComponent<UIController>();
        //rb = gameObject.GetComponent<RigidBody>();
	}
	
	// Update is called once per frame
	void Update () {
        startButton = GameObject.Find("StartButton");//need a StartButton object
        StartControl startScript = startButton.GetComponent<StartControl>();

        /**Need to fix
        if (startScript.start == true)
        {
            Destroy(gameObject.GetComponent<Rigidbody>());//this causes game to stop working
            //rb.detectCollisions = false;
        }
        else
        {
            gameObject.AddComponent<Rigidbody>();
            //rb.detectCollisions = true;
        }**/
    }

    public void buyProducts(int cost, int green)
    {
        controller = GameObject.Find("UIController");
        UIController controlUI = controller.GetComponent<UIController>();
        pointsData.money -= cost;
        pointsData.green += green;
        controlUI.setPointText();
        Debug.Log("Bought!");
    }
}
