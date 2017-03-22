using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanBar : MonoBehaviour {

	public float speed = 1.0F;
	public int yOffset = 0;

	private Vector3 startPosition;
	private Vector3 endPosition;
	private float startTime;
	private float journeyLength;

	// Use this for initialization
	void Start () {
		startTime = Time.time;

		startPosition = gameObject.transform.position;

		endPosition = new Vector3 (startPosition.x, startPosition.y + yOffset, startPosition.z);

		journeyLength = Vector3.Distance(startPosition, endPosition);

	}
	
	// Update is called once per frame
	void Update () {
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp(startPosition, endPosition, fracJourney);
	}
}
