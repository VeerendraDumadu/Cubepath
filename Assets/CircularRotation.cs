using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularRotation : MonoBehaviour {
	public Transform center;
	public float radius = 25;
	public float angle = 0;
	public float period = 10f;

	// Update is called once per frame
	void Update () {
		angle += period*Time.deltaTime; 
		float x = Mathf.Cos(angle)*radius + center.transform.position.x; //x=cos(angle)*R+a;
		float z = Mathf.Sin(angle)*radius + center.transform.position.z; //y=sin(angle)*R+b;
		this.gameObject.transform.position = new Vector2 (x,z);
	}

}
