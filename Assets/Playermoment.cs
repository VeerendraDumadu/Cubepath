using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermoment : MonoBehaviour {
	//private PlayerController playerController;
	public float speed;

	private Rigidbody rb;

	void Start ()
	{
	}
	void Update () {
		
		transform.Translate (Vector3.forward * 10 * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			transform.Rotate (Vector3.up, 90);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.up, 90);
		}
	}
}