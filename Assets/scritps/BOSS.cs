using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOSS : MonoBehaviour { 
	public static int bossHP = 20;
	// Use this for initialization
	void Start () {
		//bossHP = 7;
	}

	// Update is called once per frame
	void Update () {
		if (bossHP == 0) {
			Destroy (gameObject); 
		}
		Debug.Log (bossHP);
	}
}
