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

    public void buyProducts(int cost, int green)
    {
        UIController controlUI = GameObject.Find("UIController").GetComponent<UIController>();
        addPoints((-1 * cost), 0, green);
        controlUI.setPointText();
        Debug.Log("Bought!");
    }

    public void sellTaco(int tacoCost, int tacoPop)
    {
        pointsData.money += tacoCost;
        pointsData.popularity += tacoPop;
        addPoints(tacoCost, tacoPop, 0);
    }

    public void addPoints(int m, int p, int g)
    {
        pointsData.money += m;
        pointsData.green += g;
        pointsData.popularity += p;
    }

}
