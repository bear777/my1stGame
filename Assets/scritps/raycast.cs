using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{

	// Use this for initialization
	Camera thisCamera;
	public AudioClip gunshotSound;
	public AudioSource source;
	void Start ()
	{
		source = GetComponent <AudioSource> ();
		thisCamera = this.GetComponent<Camera> ();
		if (thisCamera == null)
			this.gameObject.SetActive (false);
	}

	void Update ()
	{
		// Mouse position is reported in screen space (measured in pixels)
		var screenPoint = Input.mousePosition;

		// Create a ray into the scene from this camera's perspective
		var ray = thisCamera.ScreenPointToRay (screenPoint);

		// Create a RaycastHit object as an output variable
		RaycastHit hit;


		// If Raycast hits something within 100 units...
		if (Physics.Raycast (ray, out hit, 50f)) {
			// ...draw a green ray extending the distance of the collision
			Debug.DrawRay (ray.origin, ray.direction * hit.distance, Color.green);
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				source.PlayOneShot (gunshotSound);
				if (hit.transform.gameObject.tag == "bad") {
					hit.collider.gameObject.GetComponent<BADIE> ().enemyHP -= 1;
					Debug.Log ("hit");
				}
				if (hit.transform.gameObject.tag == "boss") {
					BOSS.bossHP -= 1;
					Debug.Log ("hit");
				}
			}
		}
		if (hit.transform.gameObject.tag == "fakewall") {
			fakewall.fakeHP -= 1;
			Debug.Log ("hit");
			// Otherwise, draw a red ray extending 100 units into the distance
		} else {
			Debug.DrawRay (ray.origin, ray.direction * 100f, Color.red);
		}
	}
}
