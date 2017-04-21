using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class csFeedTrace : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		if(GameObject.Find("Sphere")!=null){
			
		target = GameObject.Find ("Sphere").transform;
		transform.LookAt (target);
		transform.Translate (Vector3.forward * 3 * Time.deltaTime);
		//GetComponent<Rigidbody> ().AddForce (Vector3.forward * 300 * Time.deltaTime);
		}
	}
	void OnTriggerEnter(Collider other){
		Debug.Log (other.gameObject.name);
		if (other.gameObject.name == "Sphere") {
			Destroy (target.gameObject);
		}
	}
}
