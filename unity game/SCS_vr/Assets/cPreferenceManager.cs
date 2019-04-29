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

	public string get_name () {
	  return customerName;
	}

	public string get_pref_greens() {
	  return prefGreens;
	}

	public string get_pref_meat() {
	  return prefMeat;
	}

}
