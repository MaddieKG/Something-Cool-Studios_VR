using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningTaco : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Taco;
    void OnTriggerEnter()
    {
      Debug.Log("lever hit");
        StartControl startScript = GameObject.Find("StartButton").GetComponent<StartControl>();
        if (startScript.ready == true)
        {
            Debug.Log("taco spawned");
            Instantiate(Taco, Spawnpoint.position, Spawnpoint.rotation);
        }
    }
}
