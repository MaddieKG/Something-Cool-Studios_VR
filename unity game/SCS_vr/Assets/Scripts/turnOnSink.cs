using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnSink : MonoBehaviour {
    public Transform Spawnpoint;
    public GameObject water;
    private bool turnOn = false;

    private void OnTriggerEnter(Collider col)
    {
        //Debug.Log("sink: " + col.gameObject.name);
        if (col.gameObject.name == "RightHandAnchor" || col.gameObject.name == "LeftHandAnchor")
        {
            turnOn = !turnOn;
            Instantiate(water, Spawnpoint.position, Spawnpoint.rotation);

        }
    }
}
