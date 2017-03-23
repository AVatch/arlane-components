using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductOverviewCard : MonoBehaviour {

	public string price;
	public string description;

	private Text productPriceUIComponent;
	private Text productTextUIComponent;

	// Use this for initialization
	void Start () {
		productPriceUIComponent = GameObject.FindGameObjectWithTag("Product Price").GetComponent<Text>();
		productPriceUIComponent.text = price;

		productTextUIComponent = GameObject.FindGameObjectWithTag("Product Text").GetComponent<Text>();
		productTextUIComponent.text = description;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
