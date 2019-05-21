using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public int round = 0;
    public int totalRounds = 2;
    public bool gameOver = false;
    public int customers;

    private bool roundEnd;

	// Use this for initialization
	void Start () {
        roundEnd = false;
        customers = setCustomers(10, 15);
	}
	
	// Update is called once per frame
	void Update () {
		if (round == totalRounds)
        {
            gameOver = true;
        }
        if (customers <= 0)
        {
            roundEnd = true;
        }
	}

    public int setCustomers(int min, int max)
    {
        return Random.Range(min, max);
    }
}
