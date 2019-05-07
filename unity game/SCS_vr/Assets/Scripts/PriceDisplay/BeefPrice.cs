using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeefPrice : MonoBehaviour {

    public ProductData beefData;
    public Text beefPrice;

    private GameObject beefDisplay;
    private float money;

    void Start () {
        beefDisplay = GameObject.Find("BeefPrice");

        money = beefData.money;
        beefPrice.text = "$" + money.ToString();
	}
	
}
