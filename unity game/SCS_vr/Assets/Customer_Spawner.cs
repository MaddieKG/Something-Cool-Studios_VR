using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject",
  order = 1)]
public class Customer_Spawner : ScriptableObject
{
	  public const string GREEN = "green_opt";			//Constants for entire game
		public const string NONGREEN = "nongreen_opt";

    public string prefabName;
    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;

    public all_cust_opts our_customers;

public int get_num_spawn_customers () {
	return numberOfPrefabsToCreate;
}

public void set_num_spawn_customers(int x) {
	this.numberOfPrefabsToCreate = x;
}

public void set_our_customers() {
	our_customers.set_customers_with_prefs();
}

}
