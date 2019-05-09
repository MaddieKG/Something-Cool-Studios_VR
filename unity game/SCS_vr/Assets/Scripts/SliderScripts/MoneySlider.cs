using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySlider : MonoBehaviour {

    public Slider slider;
    public Text valueText;
    private float value;

	// Use this for initialization
	void Start () {
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        value = pointsScript.pointsData.money;
        valueText.text = "$" + value.ToString();
        slider.value = value;
	}
	
	void Update () {
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        value = pointsScript.pointsData.money;
        valueText.text = "$" + value.ToString();
        slider.value = value/100;
    }
}
