using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csMainScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		Physics.gravity = new Vector3 (0, -1.0f, 0);
	}

	void OnGUI(){
		if (GUI.Button (new Rect (2100, 1350, 400, 200), "<size=50>밥 밥 밥</size>")) 
		{
			
			GameObject feed = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			feed.transform.position = new Vector3 ((float)Random.Range(-7, 7), 5.0f, 3.5f);
			feed.transform.localScale = new Vector3 (0.3f, 0.3f, 0.3f);
			feed.name = "Sphere";
			feed.AddComponent<Rigidbody> ();
			//feed.GetComponent<SphereCollider> ().isTrigger = true;
		}
		if(GUI.Button(new Rect(1700, 1350, 400, 200), "<size=50>갈색 정어리 추가</size>")){
			GameObject prefab = Resources.Load ("Sardine/Prefabs/SardineSkinWithDemoScript") as GameObject;
			GameObject fish = Instantiate (prefab) as GameObject;
			Debug.Log ("생성 됏나요");
			fish.name = "Sardine";
			fish.transform.SetParent (GameObject.Find ("Main Camera").transform.parent);
			fish.transform.localScale = new Vector3 (10, 10, 10);
			fish.transform.localPosition = new Vector3 (2, 1, 0);
			fish.transform.localRotation = Quaternion.AngleAxis(90, new Vector3(0, 1, 0));
			fish.AddComponent<CapsuleCollider> ();
			fish.GetComponent<CapsuleCollider> ().center = new Vector3 (0.0f, 0.06f, 0.08f);
			fish.GetComponent<CapsuleCollider> ().radius = 0.04f;
			fish.GetComponent<CapsuleCollider> ().height = 0.3f;
			fish.GetComponent<CapsuleCollider> ().isTrigger = true;
			fish.GetComponent<CapsuleCollider> ().direction = 2;
			fish.AddComponent<csFeedTrace> ();
			fish.AddComponent<SardineCharacter> ();
			fish.AddComponent<SardineUserController> ();
		}
		if (GUI.Button (new Rect (1300, 1350, 400, 200), "<size=50>푸른 정어리 추가</size>")) {
			GameObject prefab = Resources.Load ("Sardine/Prefabs/Ver1.2.1/SardineSkinWithController") as GameObject;
			GameObject fish = Instantiate (prefab) as GameObject;
			fish.name = "Sardine";
			fish.transform.SetParent (GameObject.Find ("Main Camera").transform.parent);
			fish.transform.localScale = new Vector3 (10, 10, 10);
			fish.transform.localPosition = new Vector3 (2, 1, 0);
			fish.transform.localRotation = Quaternion.AngleAxis(90, new Vector3(0, 1, 0));
			fish.AddComponent<CapsuleCollider> ();
			fish.GetComponent<CapsuleCollider> ().center = new Vector3 (0.0f, 0.06f, 0.08f);
			fish.GetComponent<CapsuleCollider> ().radius = 0.04f;
			fish.GetComponent<CapsuleCollider> ().height = 0.3f;
			fish.GetComponent<CapsuleCollider> ().isTrigger = true;
			fish.GetComponent<CapsuleCollider> ().direction = 2;
			fish.AddComponent<csFeedTrace> ();
		}

	}
}
