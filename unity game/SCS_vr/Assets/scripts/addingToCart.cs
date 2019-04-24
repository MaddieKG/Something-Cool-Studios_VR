using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingToCart : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "ingredient")
        {
            Debug.Log("collision detected");
        }
    }
}
