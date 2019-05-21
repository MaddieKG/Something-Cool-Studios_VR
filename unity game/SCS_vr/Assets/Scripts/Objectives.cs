using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour {
    [SerializeField] public ObjectiveData objectiveList;
    private string[] objectives;
    public int rounds;
    private string obj1, obj2, obj3, obj4;
	// Use this for initialization
	void Start () {
        GameController controller = GameObject.Find("GameManager").GetComponent<GameController>();

        obj1 = "The US-Mexico border has closed, resulting in a 10x cost increase in avocados. Guacamole is now more expensive.";
        obj2 = "Cost of chicken has skyrocketed due to innovation in chicken production. All chicken farms now provide spas to give their chickens comfortable lives.";
        obj3 = "Beef has gone on sale! The ever-popular meat is now at an all-time low price! Buy some before it's gone!";
        obj4 = "Our local farms have raised the price of their lettuce due to water shortage from the current drought.";
        objectives = new string[] { obj2, obj1, obj3, obj4 };
        objectiveList.objectives = setObjectives(objectives, 2);
    }
	
	// Update is called once per frame
	void Update () {
        UIController uicontrol = GameObject.Find("UIController").GetComponent<UIController>();
        uicontrol.setObjective(objectiveList.objectives[0]);
	}

    private string[] setObjectives(string[] list, int r)
    {
        string[] objs = new string[r];
        int[] objUsed = new int[] { 0, 0, 0, 0 };
        int val;
        bool used = false;

        for (int i = 0; i < r; i++)
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

    private void checkIngredients()
    {
        GameController controller = GameObject.Find("GameManager").GetComponent<GameController>();
        addingToCart cartScript = GameObject.Find("cart").GetComponent<addingToCart>();

        int r = controller.round;
        if (objectiveList.objectives[r] == obj1 && cartScript.currentLettuce == 0)
        {
            //do something
        } 
        else if (objectiveList.objectives[r] == obj2)
        {

        }
        else if (objectiveList.objectives[r] == obj3)
        {

        }
        else if (objectiveList.objectives[r] == obj4)
        {

        }
    }

    /*public string[] getObjectives
    {
        return { "a"}
    }*/
}
