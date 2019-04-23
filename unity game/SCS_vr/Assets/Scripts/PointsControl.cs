using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointsControl
{

    private int popularity, green;
    private float money;
    public Text moneyText, popText, greenText;

    void Start()
    {
        money = 0; //some value
        green = 0; //some value
        popularity = 0; //some value
        setText();
    }

    public float getMoney()
    {
        return money;
    }

    public int getGreen()
    {
        return green;
    }

    public int getPop()
    {
        return popularity;
    }

    //use to update whenever changes are made → make global
    void setText()
    {
        moneyText.text = "Money: " + money.ToString();
        greenText.text = "Green Points: "  + green.ToString();
        popText.text = "Popularity: " +popularity.ToString();
    }

    public void buyProducts (float cost)
    {
        money -= cost;
        setText();
	}

    public void serveCustomer (float price, int satisfaction)
    { 
        money += price;
        popularity += satisfaction;//make satis positive or negative based on likes/dislikes
        setText();
    }
   /** void customerServed ()
    {
        money += value;
        popularity += value;
        setText();
    }**/
}
