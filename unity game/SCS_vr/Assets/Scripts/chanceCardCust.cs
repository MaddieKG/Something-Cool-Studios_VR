using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chanceCardCust : MonoBehaviour
{


    public string cname = "Bob";

    //0 for not sustainable, 1 for sustainable
    public int greens = 0;
    public int meat = 0;
    public Animator anim;
    public bool ordering = false;
    public GameObject recievedTaco, tacoDetector, tacoInfo, UIcontrol;
    public string message;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        recievedTaco = GameObject.Find("plate");
        tacoInfo = GameObject.Find("cart");
        UIcontrol = GameObject.Find("UIController");
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
        detectTaco detectTaco = recievedTaco.GetComponent<detectTaco>();
        yield return new WaitForSeconds(5);
        anim.SetBool("walkBool", true);
        yield return new WaitForSeconds(3 * detectTaco.counter);
        anim.SetBool("walkBool", false);
    }
    void Update()
    {
        detectTaco detectTaco = recievedTaco.GetComponent<detectTaco>();
        addingToCart addingToCart = tacoInfo.GetComponent<addingToCart>();
        tacoDetector = GameObject.Find("plate");
        detectTaco detectScript = tacoDetector.GetComponent<detectTaco>();
        UIcontrol = GameObject.Find("UIController");
        UIController controller = UIcontrol.GetComponent<UIController>();
        if (ordering == true && detectTaco.onPlate == true)
        {

            //Debug.Log("nonorganicLover on plate: " + detectTaco.onPlate);

            if (addingToCart.currentMeat == 1)
            {
                message = "I’m so happy you’re using chicken in your tacos, that's so sustainable.";
                controller.updateTranslator(message);
                detectScript.tacoPop = -5;
                anim.SetBool("gotTacoHappy", true);
            }
            else
            {
                message = "I’m so disgusted you’re using beef in your tacos, that's so unsustainable.";
                controller.updateTranslator(message);
                detectScript.tacoPop = -5;
                anim.SetBool("gotTacoSad", true);
            }
            ordering = false;
            detectTaco.moveUpTrue();
        }
        else if (detectTaco.moveUp == true)
        {
            StartCoroutine(waitWalking());
            detectTaco.moveUpFalse();
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
