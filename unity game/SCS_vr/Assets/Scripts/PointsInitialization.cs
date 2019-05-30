using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsInitialization : MonoBehaviour {

    // Use this for initialization
    public PointsData pointsData;
	void Start () {
        pointsData.money = 15;
        pointsData.green = 50;
        pointsData.popularity = 50;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
