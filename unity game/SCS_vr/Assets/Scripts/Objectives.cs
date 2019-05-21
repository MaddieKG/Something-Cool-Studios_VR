using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives : MonoBehaviour {
    [SerializeField] public ObjectiveData objectiveList;
    [SerializeField] public ProductData beefData, chickenData, orgLettData, guacData;
    private string[] objectives;
    public int rounds;
    private string obj1, obj2, obj3, obj4;
	// Use this for initialization
	void Start () {
        GameController controller = GameObject.Find("GameManager").GetComponent<GameController>();
        beefData.money = 1.02f;
        chickenData.money = 0.75f;
        guacData.money = 0.12f;
        orgLettData.money = 0.25f;

        obj1 = "The US-Mexico border has closed, resulting in a 5x cost increase in avocados. Guacamole is now more expensive.";
        obj2 = "Cost of chicken has tripled due to innovation in chicken production. All chicken farms now provide spas to give their chickens comfortable lives.";
        obj3 = "Beef has gone on sale! The ever-popular meat is now at an all-time low price! Buy some before it's gone!";
        obj4 = "Our local farms have raised the price of their lettuce due to water shortage from the current drought.";
        objectives = new string[] { obj2, obj1, obj3, obj4 };
        objectiveList.objectives = setObjectives(objectives, 2);
        checkIngredients();
    }
	
	// Update is called once per frame
	void Update () {
        UIController uicontrol = GameObject.Find("UIController").GetComponent<UIController>();
        uicontrol.setObjective(objectiveList.objectives[0]);
	}

    private string[] setObjectives(string[] list, int r)
    {
        int val = Random.Range(0, 3);
        string[] objs = new string[r];
        objs[0] = list[val];
        objs[1] = "More people want enviromentally friendly food";
        return objs;
    }
    /*
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
    */
    private void checkIngredients()
    {
        GameController controller = GameObject.Find("GameManager").GetComponent<GameController>();
        addingToCart cartScript = GameObject.Find("cart").GetComponent<addingToCart>();

        int r = controller.round;
        if (objectiveList.objectives[r] == obj1 && cartScript.currentLettuce == 0)//should be currentTopping
        {
            guacData.money *= 5;
            Debug.Log("Guac price: " + guacData.money);
        } 
        else if (objectiveList.objectives[r] == obj2)
        {
            chickenData.money *= 3;
            Debug.Log("chicken price: " + chickenData.money);
        }
        else if (objectiveList.objectives[r] == obj3)
        {
            beefData.money *= 0.5f;
            Debug.Log("Beef price: " + beefData.money);
        }
        else if (objectiveList.objectives[r] == obj4)
        {
            orgLettData.money *= 2;
            Debug.Log("lettuce price: " + orgLettData.money);
        }
    }

    /*public string[] getObjectives
    {
        return { "a"}
    }*/
}
