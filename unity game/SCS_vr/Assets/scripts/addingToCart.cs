using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addingToCart : MonoBehaviour
{
    public int one = 0;
    public int two = 0;
    public int three = 0;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "ingredient1")
        {
            if(one >= 1)
            {
              Debug.Log("ingredient1 already picked");
              col.gameObject.transform.position = new Vector3(-1,1,-2);
            }
            if (one == 0)
            {
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
                one += 1;
            }

        }
        else if (col.gameObject.tag == "ingredient2")
        {
          if(two >= 1)
          {
            Debug.Log("ingredient2 already picked");
            col.gameObject.transform.position = new Vector3(-1,1,-2);
          }
          if (two == 0)
          {
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
              two += 1;
          }

        }
        else if (col.gameObject.tag == "ingredient3")
        {
          if(three >= 1)
          {
            Debug.Log("ingredient3 already picked");
            col.gameObject.transform.position = new Vector3(-1,1,-2);
          }
          if (three == 0)
          {
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
              three += 1;
          }

        }
    }
}
