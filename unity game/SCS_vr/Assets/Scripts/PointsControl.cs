using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointsControl
{

    private int popularity, greenPoints;
    private float money;
    public Text moneyText, popText, greenText;

    void Start()
    {
        money = 0; //some value
        greenPoints = 0; //some value
        popularity = 0; //some value
        setText();
    }

    public float getMoney()
    {
        return money;
    }

    public int getGreenPoints()
    {
        return greenPoints;
    }

    public int getPop()
    {
        return popularity;
    }

    //use to update whenever changes are made → make global
    void setText()
    {
        moneyText.text = "Money: " + money.ToString();
        greenText.text = "Green Points: "  + greenPoints.ToString();
        popText.text = "Popularity: " + popularity.ToString();
    }

    public void buyProducts (float cost, int green)
    {
        money -= cost;
        greenPoints += green;//green should be positive or negative
        setText();
	}

    public void serveCustomer (float earn, int satisfaction)
    { 
        money += earn;
        popularity += satisfaction;//make satis positive or negative based on likes/dislikes
        setText();
    }
    
   
}
