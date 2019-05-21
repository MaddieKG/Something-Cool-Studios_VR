using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextRound : MonoBehaviour
{

    private void OnTriggerEnter(Collider col)
    {
        //Debug.Log("sink: " + col.gameObject.name);
        if (col.gameObject.name == "RightHandAnchor" || col.gameObject.name == "LeftHandAnchor")
        {
            SceneManager.LoadScene(1);
        }
    }
}
