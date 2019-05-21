using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningTaco : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Taco;
    void OnTriggerEnter()
    {
        StartControl startScript = GameObject.Find("StartButton").GetComponent<StartControl>();
        if (startScript.ready == true)
        {
            Instantiate(Taco, Spawnpoint.position, Spawnpoint.rotation);
        }
    }
}
