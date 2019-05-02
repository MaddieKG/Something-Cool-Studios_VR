using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsController : MonoBehaviour {

    [SerializeField]
    private PointsData pointsData;
    public int money, green, popularity;

    // Use this for initialization
    void Start () {
        pointsData.money = 50;
        pointsData.green = 50;
        pointsData.popularity = 50;

        money = 50;
        green = 50;
        popularity = 50;
	}

    public void buyProducts(int cost, int green)
    {
        UIController controlUI = GameObject.Find("UIController").GetComponent<UIController>();
        addPoints((-1 * cost), 0, green);
        controlUI.setPointText();
    }

    public void sellTaco(int tacoCost, int tacoPop)
    {
        UIController controlUI = GameObject.Find("UIController").GetComponent<UIController>();
        money += tacoCost;
        popularity += tacoPop;
        addPoints(tacoCost, tacoPop, 0);
        controlUI.setPointText();

    }

    public void addPoints(int m, int p, int g)
    {
        money += m;
        green += g;
        popularity += p;
    }

}
