using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetIngredientPosition : MonoBehaviour {

    private Vector3 position;
    private Quaternion rotation;

	// Use this for initialization
	void Start () {
        position = gameObject.transform.position;
        rotation = gameObject.transform.rotation;
	}
	
	public Vector3 getPosition()
    {
        return position;
    }

    public Quaternion getRotation()
    {
        return rotation;
    }
}
