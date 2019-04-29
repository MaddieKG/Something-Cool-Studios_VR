using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject",
  order = 1)]
public class all_cust_opts : ScriptableObject {
	cPreferenceManager[] preferences;
	int num_customers;
	string[] names = {"Paula", "Fred", "Pablo", "Samantha", "Shawn", "Sianna", "Raymond", "Riley", "Calvin", "Ms. Marvel", "Emily", "Caped Crusader", "Bruce","Peter","Shawna",
										"John","Sarah","Barry", "Finn", "Mr. Man", "Claire", "A. Alex"};

	// Use this for initialization
	void Start () {
	}

	public void create_customers() {
		//Random rand = new Random();
		//this.num_customers = .get_num_spawn_customers();

		string prefGreens = Customer_Spawner.GREEN;
		string prefMeat = Customer_Spawner.NONGREEN;

		for (int i = 0; i < 10; i++) {
			int index = Random.Range(0, preferences.Length);
			preferences[i] = new cPreferenceManager();
			preferences[i].set_name(names[index]);
			 if (i==1) { 	//Can clean this up later-- values will repeat over
				prefGreens = Customer_Spawner.NONGREEN;
			} else if (i==2) {
				prefMeat = Customer_Spawner.GREEN;
			} else if (i==3) {
				prefGreens = Customer_Spawner.GREEN;
				prefMeat = Customer_Spawner.GREEN;
			} else if (i==4) {
				prefGreens = Customer_Spawner.GREEN;
				prefMeat = Customer_Spawner.NONGREEN;
			} else if (i==5) {
				prefGreens = Customer_Spawner.NONGREEN;
				prefMeat = Customer_Spawner.NONGREEN;
			} else if (i==6) {
				prefGreens = Customer_Spawner.GREEN;
				prefMeat = Customer_Spawner.GREEN;
			} else if (i==7) {
				prefGreens = Customer_Spawner.NONGREEN;
				prefMeat = Customer_Spawner.NONGREEN;
			} else if (i==8) {
				prefGreens = Customer_Spawner.GREEN;
				prefMeat = Customer_Spawner.GREEN;
			} else if (i==9) {
				prefGreens = Customer_Spawner.GREEN;
				prefMeat = Customer_Spawner.GREEN;
			}
			preferences[i].set_pref_meat(prefMeat);
			preferences[i].set_pref_greens(prefGreens);
		}
	}

	public cPreferenceManager[] set_customers_with_prefs() {
		create_customers();
		return preferences;
	}

	public cPreferenceManager[] get_customers_with_prefs() {
		return preferences;
	}







	// Update is called once per frame
	void Update () {

	}
}
