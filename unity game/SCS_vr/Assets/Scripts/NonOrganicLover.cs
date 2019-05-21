using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonOrganicLover : MonoBehaviour {


    public string cname = "Bob";

    //0 for not sustainable, 1 for sustainable
    public int greens = 0;
    public int meat = 0;
    public Animator anim;
    public bool ordering = false;
    public GameObject recievedTaco;
    public GameObject tacoInfo;

    void Start () {
        anim = gameObject.GetComponent<Animator>();
        recievedTaco = GameObject.Find("plate");
        tacoInfo = GameObject.Find("cart");
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
            anim.SetBool("walkBool",false);
            anim.SetBool("talkStage", true);
        }
    }
    private IEnumerator waitWalking()
    {
      yield return new WaitForSeconds(4);
      anim.SetBool("walkBool", true);
      yield return new WaitForSeconds(1);
      anim.SetBool("walkBool", false);
    }
    void Update()
    {

        detectTaco detectTaco = recievedTaco.GetComponent<detectTaco>();
        addingToCart addingToCart = tacoInfo.GetComponent<addingToCart>();
        Debug.Log("taco on plate: " + detectTaco.onPlate);
        if (ordering == true && detectTaco.onPlate == true) {

            Debug.Log("nonorganicLover on plate: " + detectTaco.onPlate);

            if (addingToCart.currentMeat == 1)
            {
                anim.SetBool("gotTacoHappy", true);
            }
            else
            {
                anim.SetBool("gotTacoSad", true);
            }
            detectTaco.moveUpTrue();
        }
        if (detectTaco.moveUp == true)
        {
            StartCoroutine(waitWalking());
        }
    }

        /*
        if(detectTaco.onPlate == true)
        {
          detectTaco.setTacoFalse();
          Debug.Log("nonorganicLover on plate: " + detectTaco.onPlate);
          detectTaco.moveUpTrue();
          Debug.Log(detectTaco.onPlate);
          //beef = 0, chicken = 1, gmoLettuce = 0, other lettuce = 1
          if(ordering == true)
          {
            if(addingToCart.currentMeat == 1)
            {
              anim.SetBool("gotTacoHappy", true);
                    Debug.Log(anim.GetCurrentAnimatorStateInfo().TagHash);
            }
            else
            {
                anim.SetBool("gotTacoSad", true);

                    Debug.Log(anim.GetCurrentAnimatorStateInfo().TagHash);
            }
          }
        }
        else if(detectTaco.moveUp == true)
        {
          StartCoroutine(waitWalking());
        }
    }*/
}
