using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "MonoBehaviour/cPreferenceManager",
  order = 1)]
public class cPreferenceManager : MonoBehaviour
{
  private string customerName;
  private string prefGreens;
  private string prefMeat;

	string public get_name () {
	  return customerName;
	}

	string public get_pref_greens() {
	  return prefGreens;
	}

	string public get_pref_meat() {
	  return prefMeat;
	}

}
