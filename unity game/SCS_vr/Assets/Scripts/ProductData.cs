using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductData : MonoBehaviour {

    public class Product
    {
        public float cost;
        public int green;
        public int happiness;

        public Product(float c, int g, int h)
        {
            cost = c;
            green = g;
            happiness = h;
        }
    }
}
