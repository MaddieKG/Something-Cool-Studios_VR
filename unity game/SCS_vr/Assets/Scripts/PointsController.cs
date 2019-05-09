using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsController : MonoBehaviour {

    [SerializeField]
    public PointsData pointsData;
    //public int money, green, popularity;

    // Use this for initialization
    void Start () {
        /*
        pointsData.money = 20;
        pointsData.green = 50;
        pointsData.popularity = 50;
        */
	}

    public void buyProducts(float cost, int green)
    {
        UIController controlUI = GameObject.Find("UIController").GetComponent<UIController>();
        addPoints((-1 * cost), 0, green);
        controlUI.setPointText();
    }

    public void sellTaco(float tacoCost, int tacoPop)
    {
        UIController controlUI = GameObject.Find("UIController").GetComponent<UIController>();
        addPoints(tacoCost, tacoPop, 0);
        controlUI.setPointText();

    }

    public void addPoints(float m, int p, int g)
    {
        pointsData.money += m;
        pointsData.green += g;
        pointsData.popularity += p;
    }

}
