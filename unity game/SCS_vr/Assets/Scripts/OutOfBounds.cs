using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ingredient1" || other.gameObject.tag == "ingredient2" || other.gameObject.tag == "ingredient3")
        {
            GetIngredientPosition positionScript = other.gameObject.GetComponent<GetIngredientPosition>();
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.transform.position = positionScript.getPosition();
            other.gameObject.transform.rotation = positionScript.getRotation();
        }
    }
}
