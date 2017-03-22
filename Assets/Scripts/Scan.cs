using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scan : MonoBehaviour {

	public int offsetY;
	public float speed = 1.0F;

	private float startTime;
	private Vector3 start;
	private Vector3 destination;
	private float journeyLength;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		start = gameObject.transform.position;
		destination = new Vector3 (start.x, start.y + offsetY, start.z);
		journeyLength = Vector3.Distance(start, destination);
	}
	
	// Update is called once per frame
	void Update () {
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp(start, destination, fracJourney);
	}
}
