using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour {

	void OnTriggerEnter(Collider col){

		if (col.GetComponent<Collider> ().tag == "cross") {
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().front = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().back = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().left = true;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().right = false;
		}


	}



}

