using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrgLettFact : MonoBehaviour
{
    private GameObject infoCanvas;
    private Vector3 displacement = new Vector3(0, 0.1f, 0);
    public Camera cameraToLookAt;

    // Use this for initialization
    void Start()
    {
        infoCanvas = GameObject.Find("OrgLettInfo");
        infoCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        infoCanvas.transform.position = gameObject.transform.position + displacement;
        infoCanvas.transform.rotation = cameraToLookAt.transform.rotation;
    }

    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.name == "LeftHandAnchor" || col.gameObject.name == "RightHandAnchor")
        {
            infoCanvas.GetComponent<RectTransform>().anchoredPosition = new Vector3(0.0f, 0.0f);//gameObject.transform.position.x, gameObject.transform.position.y + 10.0f);//gameObject.transform.position + displacement;
            infoCanvas.transform.rotation = cameraToLookAt.transform.rotation;
            infoCanvas.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "LeftHandAnchor" || col.gameObject.name == "RightHandAnchor")
        {
            infoCanvas.SetActive(false);
        }
    }
}
