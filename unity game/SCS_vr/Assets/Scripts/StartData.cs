using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New StartData", menuName = "Start Data", order = 51)]
public class StartData : ScriptableObject {

    [SerializeField]
    public bool start;
}
