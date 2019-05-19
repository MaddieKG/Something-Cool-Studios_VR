using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour {

    private string[] objectives;
    public int rounds;
    private string obj1, obj2, obj3, obj4;
	// Use this for initialization
	void Start () {
        obj1 = "Shady Sal's lettuce has had an E.coli outbreak. People won't want to buy food made with it. On the bright side, Shady Sal's prices are now lower than ever.";
        obj2 = "Cost of chicken has skyrocketed due to innovation in chicken production. All chicken farms now provide spas to give their chickens comfortable lives.";
        obj3 = "Beef has gone on sale! The ever-popular meat is now at an all-time low price! Buy some before it's gone!";
        obj4 = "Our local farms have raised the price of their lettuce due to water shortage from the current drought.";
        objectives = new string[] { obj1, obj2, obj3, obj4 };
        objectives = setObjectives(objectives);
    }
	
	// Update is called once per frame
	void Update () {
        UIController uicontrol = GameObject.Find("UIController").GetComponent<UIController>();
        uicontrol.setObjective(objectives[0]);
	}

    public string[] setObjectives(string[] list)
    {
        string[] objs = new string[4];
        int[] objUsed = new int[] { 0, 0, 0, 0 };
        int val;
        bool used = false;

        for (int i = 0; i < rounds; i++)
        {
            used = false;
            while (used == false)
            {
                val = Random.Range(0, 3);
                if (objUsed[val] == 0)
                {
                    objs[i] = list[val];
                    objUsed[val] = 1;
                    used = true;
                }
            }
        }
        return objs;
    }
}
