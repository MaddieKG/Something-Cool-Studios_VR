using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PointsControl : MonoBehaviour
{
    public int popularity, greenPoints;
    public float money;
    public Text moneyText, popText, greenText;

    void Start()
    {
        money = 20; //some value
        greenPoints = 10; //some value
        popularity = 5; //some value
        SetText();
    }

    //geters and setters
    public float GetMoney()
    {
        return money;
    }

    public void SetMoney(float mon)
    {
        money = mon;
    }

    public int GetGreenPoints()
    {
        return greenPoints;
    }

    public void SetGreenPoints(int green)
    {
        greenPoints = green;
    }

    public int GetPop()
    {
        return popularity;
    }

    public void SetPop(int pop)
    {
        popularity = pop;
    }

    //Other functions start here

    //use to update whenever changes are made → make global
    private void SetText()
    {
        moneyText.text = "Money: " + money.ToString();
        greenText.text = "Green Points: "  + greenPoints.ToString();
        popText.text = "Popularity: " + popularity.ToString();
    }

    //Function to be used when buying products to make tacos
    //Updates money & green points
    public void BuyProducts (float cost, int green)
    {
        money -= cost;
        greenPoints += green;//green should be positive or negative
        SetText();
	}

    //Used when a customer receives their food
    //Updates money & customer popularity points
    public void ServeCustomer (float earn, int satisfaction)
    { 
        money += earn;
        popularity += satisfaction;//make satis positive or negative based on likes/dislikes
        SetText();
    }

}
