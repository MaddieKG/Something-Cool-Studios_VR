using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningTaco : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject[] Taco;
    void OnTriggerEnter()
    {
        StartControl startScript = GameObject.Find("StartButton").GetComponent<StartControl>();
        addingToCart pickTaco = GameObject.Find("cart").GetComponent<addingToCart>();
        if (startScript.ready == true)
        {
            //currentMeat = 0 if picked beef and = 1 if picked chicken
            if (pickTaco.currentMeat == 0) //taco_beef_guac
            {
                Instantiate(Taco[0], Spawnpoint.position, Spawnpoint.rotation);
            }
            else if (pickTaco.currentMeat == 1) //taco_chicken_guac
            {
                Instantiate(Taco[1], Spawnpoint.position, Spawnpoint.rotation);
            }
        }
    }
}
