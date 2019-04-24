using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingToCart : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "nonvegan")
        {
            Debug.Log("nonvegan collision detected");
        }
        else if (col.gameObject.tag == "vegan")
        {
            Debug.Log("vegan collision detected");
        }
    }
}
