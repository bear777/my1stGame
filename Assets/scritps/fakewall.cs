using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakewall : MonoBehaviour { 
	public static int fakeHP = 2;
	// Use this for initialization
	void Start () {
		//fakeHP = 7;
	}

	// Update is called once per frame
	void Update () {
		if (fakeHP == 0) {
			Destroy (gameObject); 
		}
		Debug.Log (fakeHP);
	}
}
