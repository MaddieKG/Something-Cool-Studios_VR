using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutMoneySlider : MonoBehaviour
{

    public Slider slider;
    public Text valueText;
    private float value;

    // Use this for initialization
    void Start()
    {
        tutorialPointsController pointsScript = GameObject.Find("PointsController").GetComponent<tutorialPointsController>();
        value = pointsScript.pointsData.money;
        valueText.text = "$" + value.ToString("0.##");
        slider.value = value;
    }

    void Update()
    {
        tutorialPointsController pointsScript = GameObject.Find("PointsController").GetComponent<tutorialPointsController>();
        value = pointsScript.pointsData.money;
        valueText.text = "$" + value.ToString("0.##");
        slider.value = value / 100;
    }
}
