using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class cameraPos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		UnityEngine.XR.InputTracking.Recenter();
	}
}
