using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrades : MonoBehaviour {

    [SerializeField] public PointsData points;
    private GameObject upgradeMusic, upgradeBanner;
    private bool onPress;

    // Use this for initialization
    void Start()
    {
        upgradeMusic = GameObject.Find("TacoBoutMusic-wav");
        upgradeBanner = GameObject.Find("sign");
        upgradeBanner.SetActive(false);
        upgradeMusic.SetActive(false);

        onPress = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        GameObject currentUpgrade;
        if ((other.gameObject.name == "RightHandAnchor" || gameObject.name == "LeftHandAnchor") && onPress == false)
        {
            currentUpgrade = getUpgrade(0);
            currentUpgrade.SetActive(true);
            pointsScript.addPoints(points.money *= 0.2f, 0, 0);
            onPress = true;
        }
    }

    private GameObject getUpgrade(int r)
    {
        if (r == 0)
        {
            return upgradeBanner;
        }
        else
        {
            return upgradeMusic;
        }
    }
}
