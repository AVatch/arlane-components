using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductPopover : MonoBehaviour {

	// inputs for the product
	public string productPrice;
	public string productText;

	public string relatedProduct1Title;
	public string relatedProduct1Price;
	public string relatedProduct1Text;

	public string relatedProduct2Title;
	public string relatedProduct2Price;
	public string relatedProduct2Text;

	// wire up the assets
	private Text productPriceUIComponent;
	private Text productTextUIComponent;

	private Text relatedProduct1TitleUIComponent;
	private Text relatedProduct1PriceUIComponent;
	private Text relatedProduct1TextUIComponent;

	// Use this for initialization
	void Start () {
		// assign values to the ui components
		productPriceUIComponent = GameObject.FindGameObjectWithTag("Product Price").GetComponent<Text>();
		productPriceUIComponent.text = productPrice;

		productTextUIComponent = GameObject.FindGameObjectWithTag("Product Text").GetComponent<Text>();
		productTextUIComponent.text = productText;

		productTextUIComponent = GameObject.FindGameObjectWithTag("Product Text").GetComponent<Text>();
		productTextUIComponent.text = productText;

		relatedProduct1TitleUIComponent = GameObject.FindGameObjectWithTag("Related Product Title 1").GetComponent<Text>();
		relatedProduct1TitleUIComponent.text = relatedProduct1Title;
		relatedProduct1PriceUIComponent = GameObject.FindGameObjectWithTag("Related Product Price 1").GetComponent<Text>();
		relatedProduct1PriceUIComponent.text = relatedProduct1Price;
		relatedProduct1TextUIComponent = GameObject.FindGameObjectWithTag("Related Product Text 1").GetComponent<Text>();
		relatedProduct1TextUIComponent.text = relatedProduct1Text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
