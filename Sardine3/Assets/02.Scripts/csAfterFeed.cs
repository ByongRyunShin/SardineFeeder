using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csAfterFeed : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	void onTriggerEnter(Collider other){
		Destroy (this.gameObject);
	}
}
