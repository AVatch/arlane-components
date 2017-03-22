using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class product : MonoBehaviour {

	// inputs for the product
	public string productPrice;
	public string productText;

	// wire up the assets
	private Text productPriceUIComponent;
	private Text productTextUIComponent;

	// Use this for initialization
	void Start () {
		// assign values to the ui components
		productPriceUIComponent = GameObject.FindGameObjectWithTag("Product Price").GetComponent<Text>();
		productPriceUIComponent.text = productPrice;

		productTextUIComponent = GameObject.FindGameObjectWithTag("Product Text").GetComponent<Text>();
		productTextUIComponent.text = productText;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
