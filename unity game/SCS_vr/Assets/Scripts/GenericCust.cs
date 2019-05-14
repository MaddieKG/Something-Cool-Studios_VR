using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericCust : MonoBehaviour
{


    public string cname = "Paul";

    //0 for not sustainable, 1 for sustainable
    public int greens;
    public int meat;
    private Animator anim;

    void Start()
    {
        greens = Random.Range(0, 2);
        meat = Random.Range(0, 2);
        anim = GetComponent<Animator>();
        Debug.Log("name: " + cname);
        Debug.Log("green: " + greens.ToString());
        Debug.Log("meat: " + meat.ToString());
    }

    public string getName()
    {
        return cname;
    }

    public int getGreens()
    {
        return greens;
    }

    public int getMeat()
    {
        return meat;
    }

    void Update()
    {
        anim.SetBool("TestBool", true);
    }
}
