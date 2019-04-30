using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New PointsData", menuName = "Points Data", order = 51)]
public class PointsData : ScriptableObject{
    [SerializeField]
    public int money, green, popularity;

    void Start ()
    {
        money = 50;
        green = 50;
        popularity = 50;
    }

    public int Money
    {
        get
        {
            return money;
        }
    }

    public int Green
    {
        get
        {
            return green;
        }
    }

    public int Popularity
    {
        get
        {
            return popularity;
        }
    }
}
