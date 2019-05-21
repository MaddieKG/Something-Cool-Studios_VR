using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenLover : MonoBehaviour
{


    public string cname = "Andy";

    //0 for not sustainable, 1 for sustainable
    public int greens = 0;
    public int meat = 1;
    public Animator anim;
    public bool ordering = false;
    public GameObject recievedTaco;
    public GameObject tacoInfo;

    void Start()
    {
        recievedTaco = GameObject.Find("plate");
        tacoInfo = GameObject.Find("cart");
        anim = gameObject.GetComponent<Animator>();
        /*
        Debug.Log("name: " + cname);
        Debug.Log("green: " + greens.ToString());
        Debug.Log("meat: " + meat.ToString());
        */
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

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "orderPos")
        {
            ordering = true;
            anim.SetBool("walkBool", false);
            anim.SetBool("talkStage", true);
        }
    }
    private IEnumerator waitWalking()
    {
        yield return new WaitForSeconds(5);
      anim.SetBool("walkBool", true);
      yield return new WaitForSeconds(4);
      anim.SetBool("walkBool", false);
    }
    void Update()
    {
        detectTaco detectTaco = recievedTaco.GetComponent<detectTaco>();
        addingToCart addingToCart = tacoInfo.GetComponent<addingToCart>();
        if (ordering == true && detectTaco.onPlate == true)
        {
            Debug.Log("customer served");
            //beef = 0, chicken = 1, gmoLettuce = 0, other lettuce = 1
                if(addingToCart.currentMeat == 1)
                {
                    anim.SetBool("gotTacoHappy", true);
                }
                else
                {
                    anim.SetBool("gotTacoSad", true);
                }
            ordering = false;
            detectTaco.moveUpTrue();
        }
        else if(detectTaco.moveUp == true)
        {
            StartCoroutine(waitWalking());
            detectTaco.moveUpFalse();
            Debug.Log("customer leaving");
        }
    }
}
