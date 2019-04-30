using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductController : MonoBehaviour {
    [SerializeField]
    public PointsData pointsData;

    public int money, green;
    private GameObject startButton, UIcontroller;
    //private RigidBody rb;

    // Use this for initialization
    void Start() {
        UIcontroller = GameObject.Find("UI Controller");
        UIController controlUI = UIcontroller.GetComponent<UIcontroller>();
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

    void buyProducts(int cost, int green)
    {
        pointsData.money -= cost;
        pointsData.green += green;
        controlUI.SetPointsText();
    }
}
