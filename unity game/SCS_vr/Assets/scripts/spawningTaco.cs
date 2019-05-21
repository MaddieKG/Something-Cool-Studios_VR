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
            //currentTopping = 0 if picked pico and = 1 if picked guac
            if (pickTaco.currentMeat == 0 && pickTaco.currentTopping == 0) //taco_beef_pico
            {
                Instantiate(Taco[0], Spawnpoint.position, Spawnpoint.rotation);
            }
            else if (pickTaco.currentMeat == 0 && pickTaco.currentTopping == 1) //taco_beef_guac
            {
                Instantiate(Taco[1], Spawnpoint.position, Spawnpoint.rotation);
            }
            else if (pickTaco.currentMeat == 1 && pickTaco.currentTopping == 0) //taco_chicken_pico
            {
                Instantiate(Taco[2], Spawnpoint.position, Spawnpoint.rotation);
            }
            else if (pickTaco.currentMeat == 1 && pickTaco.currentTopping == 1) //taco_chicken_guac
            {
                Instantiate(Taco[3], Spawnpoint.position, Spawnpoint.rotation);
            }
        }
    }
}
