using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutPopSlider : MonoBehaviour
{

    public Slider slider;
    public Text valueText;
    private float value;

    // Use this for initialization
    void Start()
    {
        tutorialPointsController pointsScript = GameObject.Find("PointsController").GetComponent<tutorialPointsController>();
        value = pointsScript.pointsData.popularity;
        valueText.text = value.ToString();
        slider.value = value;
    }

    void Update()
    {
        tutorialPointsController pointsScript = GameObject.Find("PointsController").GetComponent<tutorialPointsController>();
        value = pointsScript.pointsData.popularity;
        valueText.text = value.ToString();
        slider.value = value / 100;
    }
}
