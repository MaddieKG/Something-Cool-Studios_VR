using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartControl : MonoBehaviour {

    public bool start;
	//object this is attached to needs a RigidBody

	void Start () {
        start = false;
	}

	
	void Update () {
	    //may need for future use
	}

    //Is button colliding with player hand?
    //Returns bool
    private bool IsHand(Collider other)
    {
        if (other.transform.parent && other.transform.parent.parent && other.transform.parent.parent.GetComponent<HandModel>())
            return true;
        else
            return false;
    }

    //Checks whenever something collides with object if it is hand
    //Changes start variable
    void OnTriggerEnter(Collider other)
    {
        if (IsHand(other))
        {
            Debug.Log("Yay! A hand collided!");
            start = !start;
        }
    }
}
