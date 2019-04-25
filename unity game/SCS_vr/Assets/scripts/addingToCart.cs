using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingToCart : MonoBehaviour
{
    bool one = false;
    bool two = false;
    bool three = false;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ingredient1")
        {
            if (one == false)
            {
                one = true;
                if (col.gameObject.name == "nonvegan1")
                {
                    Debug.Log("nonvegan1 collision detected");
                    //change points
                }
                else if (col.gameObject.name == "vegan1")
                {
                    Debug.Log("vegan1 collision detected");
                    //change points
                }
            }
            else
            {
                Debug.Log("ingredient1 already picked");
                //reject object
            }
            
        }
        else if (col.gameObject.tag == "ingredient2")
        {
            if (two == false)
            {
                two = true;
                if (col.gameObject.name == "nonvegan2")
                {
                    Debug.Log("nonvegan2 collision detected");
                    //change points
                }
                else if (col.gameObject.name == "vegan2")
                {
                    Debug.Log("vegan2 collision detected");
                    //change points
                }
            }
            else
            {
                Debug.Log("ingredient2 already picked");
                //reject object
            }

        }
        else if (col.gameObject.tag == "ingredient3")
        {
            if (three == false)
            {
                three = true;
                if (col.gameObject.name == "nonvegan3")
                {
                    Debug.Log("nonvegan3 collision detected");
                    //change points
                }
                else if (col.gameObject.name == "vegan3")
                {
                    Debug.Log("vegan3 collision detected");
                    //change points
                }
            }
            else
            {
                Debug.Log("ingredient3 already picked");
                //reject object
            }

        }
    }
}
