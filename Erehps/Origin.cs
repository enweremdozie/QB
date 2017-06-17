using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Origin : MonoBehaviour {
	public GameObject QB;
	bool front;
	bool back;
	bool left;
	bool right;

	void Start(){
		front = false;
		back = false;
		left = false;
		right = false;
	}

	void Update(){
		front = GameObject.Find ("QB Parent").GetComponent<GravityScript> ().front;
		back = GameObject.Find ("QB Parent").GetComponent<GravityScript> ().back;
		left = GameObject.Find ("QB Parent").GetComponent<GravityScript> ().left;
		right = GameObject.Find ("QB Parent").GetComponent<GravityScript> ().right;
	}

	void OnTriggerEnter(Collider col){

		if (col.GetComponent<Collider> ().tag == "cross" && (front == true || back == true || left == true || right == true)) {
			Debug.Log ("Origin Collider works");
			QB.transform.position = new Vector3(0, -0.19f, 0);
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().front = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().back = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().left = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().right = false;
			front = false;
			back = false;
			left = false;
			right = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().origin = true;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().Layer = 0;
		}

	}
}
