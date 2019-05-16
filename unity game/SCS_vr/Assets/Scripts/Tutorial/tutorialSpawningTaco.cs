using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialSpawningTaco : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Taco;
    void OnTriggerEnter()
    {
        tutorialStartControl startScript = GameObject.Find("StartButton").GetComponent<tutorialStartControl>();
        if (startScript.ready == true)
        {
            Instantiate(Taco, Spawnpoint.position, Spawnpoint.rotation);
        }
    }
}
