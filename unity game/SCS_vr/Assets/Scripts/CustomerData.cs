using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Customer Data", menuName = "Customer Data", order = 51)]
public class CustomerData : ScriptableObject {
    public int green, meat;
    public string name;
    //[SerializeField] private Animator anim = GetComponent<Animator>;

    public int Green
    {
        get { return green; }
    }

    public int Meat
    {
        get { return meat; }
    }

    public string Name
    {
        get { return name; }
    }
}
