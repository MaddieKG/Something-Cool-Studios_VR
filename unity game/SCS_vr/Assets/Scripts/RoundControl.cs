using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RoundControl : MonoBehaviour
{
    //please attach to a EndButton object
    public RoundData roundData;
    public int customers;

    void Start()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
        customers = 6;
    }

    void Update()
    {
        StartControl startScript = GameObject.Find("StartButton").GetComponent<StartControl>();

        if (customers == 0)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }

    private void OnTriggerEnter()
    {
        if (roundData.currentRound < roundData.rounds)
        {
            SceneManager.LoadScene("Rounds");
            roundData.currentRound += 1;
        }
        else
        {
            Debug.Log("Game Over");
        }
    }
}
