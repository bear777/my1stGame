using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BADIE : MonoBehaviour { 
	public int enemyHP = 5;
	// Use this for initialization
	void Start () {
		//enemyHP = 7;
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHP == 0) {
			Destroy (gameObject); 
		}
		Debug.Log (enemyHP);
	}
}
