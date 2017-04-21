using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMove : MonoBehaviour {

	float speed = 20.0f;
	// Use this for initialization
	void Start () {
		Physics.gravity = new Vector3 (0, -1.5f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		/*
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		h = h * speed * Time.deltaTime;
		v = v * speed * Time.deltaTime;

		transform.Translate (Vector3.right * h);
		transform.Translate (Vector3.forward * v);
		if(Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody>().velocity = new Vector3 (0, 10, 0);
		}
		*/
	}
}
