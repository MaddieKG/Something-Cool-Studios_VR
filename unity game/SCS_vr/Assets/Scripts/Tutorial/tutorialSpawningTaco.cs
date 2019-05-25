using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialSpawningTaco : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Taco;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "RightHandAnchor" || col.gameObject.name == "LeftHandAnchor")
        {
            tutorialStartControl startScript = GameObject.Find("StartButton").GetComponent<tutorialStartControl>();
            TitleControl titleControl = GameObject.Find("start").GetComponent<TitleControl>();
            if (startScript.ready == true)
            {
                titleControl.setS2(false);
                titleControl.setS3(true);
                Instantiate(Taco, Spawnpoint.position, Spawnpoint.rotation);
            }
        }
        
    }
}
