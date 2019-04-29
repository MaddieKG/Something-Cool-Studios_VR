using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductController : MonoBehaviour {
    public Product[] allProductData;
    private Product beef, chicken, gmoLett, orgLett;


    // Use this for initialization
    void Start() {
        beef = new Product(3, -1, 3);
        chicken = new Product(2, 1, 1);
        gmoLett = new Product(1, -1, 1);
        orgLett = new Product(2, 2, 2);

        allProductData = new Product[] { beef, chicken, gmoLett, orgLett };
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
