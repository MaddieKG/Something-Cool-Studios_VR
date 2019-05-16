using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChickenPrice : MonoBehaviour
{

    public ProductData chickenData;
    public Text chickenPrice;

    private GameObject chickenDisplay;
    private float money;

    void Start()
    {
        chickenDisplay = GameObject.Find("chickenPrice");

        money = chickenData.money;
        chickenPrice.text = "$" + money.ToString();
    }

}
