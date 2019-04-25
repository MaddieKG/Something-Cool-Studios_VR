using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointsControl : MonoBehaviour
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

    //geters and setters
    public float getMoney()
    {
        return money;
    }

    public void setMoney(float mon)
    {
        money = mon;
    }

    public int getGreenPoints()
    {
        return greenPoints;
    }

    public void setGreenPoints(int green)
    {
        greenPoints = green;
    }

    public int getPop()
    {
        return popularity;
    }

    public void setPop(int pop)
    {
        popularity = pop;
    }

    //Other functions start here

    //use to update whenever changes are made → make global
    public void setText()
    {
        moneyText.text = "Money: " + money.ToString();
        greenText.text = "Green Points: "  + greenPoints.ToString();
        popText.text = "Popularity: " + popularity.ToString();
    }

    //Function to be used when buying products to make tacos
    //Updates money & green points
    public void buyProducts (float cost, int green)
    {
        money -= cost;
        greenPoints += green;//green should be positive or negative
        setText();
	}

    //Used when a customer receives their food
    //Updates money & customer popularity points
    public void serveCustomer (float earn, int satisfaction)
    { 
        money += earn;
        popularity += satisfaction;//make satis positive or negative based on likes/dislikes
        setText();
    }

}
