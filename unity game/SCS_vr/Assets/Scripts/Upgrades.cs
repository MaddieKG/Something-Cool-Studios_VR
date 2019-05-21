using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour {

    [SerializeField] public PointsData points;
    private GameObject upgradeMusic, upgradeBanner, currentUpgrade;
    public Text upgradeText;
    private bool onPress;

    // Use this for initialization
    void Start()
    {
        upgradeMusic = GameObject.Find("TacoBoutMusic-wav");
        upgradeBanner = GameObject.Find("sign");
        upgradeBanner.SetActive(false);
        upgradeMusic.SetActive(false);

        currentUpgrade = getUpgrade(1);
        onPress = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        PointsController pointsScript = GameObject.Find("PointsController").GetComponent<PointsController>();
        if ((other.gameObject.name == "RightHandAnchor" || gameObject.name == "LeftHandAnchor") && onPress == false)
        {
            currentUpgrade.SetActive(true);
            pointsScript.addPoints(points.money *= 0.2f, 0, 0);
            onPress = true;
        }
    }

    private GameObject getUpgrade(int r)
    {
        if (r == 0)
        {
            upgradeText.text = "Buy Banner";
            return upgradeBanner;
        }
        else
        {
            upgradeText.text = "Buy music";
            return upgradeMusic;
        }
    }
}
