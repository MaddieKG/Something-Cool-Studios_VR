using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addIngredients : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ingredient1" && ing1In == false)
        {
            Debug.Log("ingredient 1 in");
            ing1In = true;
            ing1Name = col.gameObject.name;
        }
        if (col.gameObject.tag == "ingredient2" && ing2In == false)
        {
            Debug.Log("ingredient 2 in");
            ing2In = true;
            ing2Name = col.gameObject.name;
        }
        if (ing1In == true && ing2In == true)
        {
            Debug.Log("Both ingredient in");
            conflict = true;
        }
        itemsInCart += 1;
        addData(col.gameObject.name, 1);
        Debug.Log("Total cost: " + totalCost);
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "ingredient1" && ing1In == true)
        {
            Debug.Log("ingredient 1 out");
            ing1In = false;
            ing1Name = null;
        }
        if (col.gameObject.tag == "ingredient2" && ing2In == true)
        {
            Debug.Log("ingredient 2 out");
            ing2In = false;
            ing2Name = null;
        }
        else
        {
            conflict = false;
        }
        itemsInCart -= 1;
        addData(col.gameObject.name, -1);
    }

}
