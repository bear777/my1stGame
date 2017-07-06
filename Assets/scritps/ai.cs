using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ai : MonoBehaviour {
	public float walkingdistance = 10.0f;
	public Transform player;
	public float smoothtime = 10.0f;
		private Vector3 smoothvelocity = Vector3.zero * 25.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (player);

		float distance = Vector3.Distance (transform.position, player.position);

		if (distance < walkingdistance)
			transform.position = Vector3.SmoothDamp (transform.position, player.position, ref smoothvelocity, smoothtime);
	}
}
