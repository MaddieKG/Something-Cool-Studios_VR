using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ProductData", menuName = "Product Data", order = 51)]
public class ProductData : ScriptableObject {

    [SerializeField]
    public float money; 
    public int green;

    public float Money
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
}
