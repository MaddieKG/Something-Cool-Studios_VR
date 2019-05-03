using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsController : MonoBehaviour {

    [SerializeField]
    private PointsData pointsData;

    // Use this for initialization
    void Start () {
        pointsData.money = 50;
        pointsData.green = 50;
        pointsData.popularity = 50;
	}
	
}
