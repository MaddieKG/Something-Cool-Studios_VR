using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewsGenerator : MonoBehaviour {

    public Text newsText;
    private string[] articles; 
    
    void Start () {
        articles = new string[] { "NEWS 1", "NEWS 2", "NEWS 3", "NEWS 4" };
        SetText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void createArticleArray()
    {

    }

    private void SetText()
    {
        string currentArticle = articles[Random.Range(0, articles.Length)];
        newsText.text = currentArticle;
    }
}
