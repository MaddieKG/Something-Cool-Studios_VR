using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New RoundData", menuName = "Round Data", order = 51)]
public class RoundData : ScriptableObject {
    
    [SerializeField]  public int rounds = 2;
    [SerializeField]  public int currentRound = 0;
}
