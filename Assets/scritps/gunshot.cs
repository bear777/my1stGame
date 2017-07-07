using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunshot : MonoBehaviour {
	public AudioClip gunshotSound;
	public AudioSource source;
	// Use this for initialization
	void Start () {
		source = GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
