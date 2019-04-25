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
        Instantiate(Taco, Spawnpoint.position, Spawnpoint.rotation);
    }
}
