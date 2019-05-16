using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GMOLettPrice : MonoBehaviour
{

    public ProductData gmoLettData;
    public Text gmoLettPrice;

    private GameObject gmoLettDisplay;
    private float money;

    void Start()
    {
        gmoLettDisplay = GameObject.Find("gmoLettPrice");

        money = gmoLettData.money;
        gmoLettPrice.text = "$" + money.ToString();
    }

}
