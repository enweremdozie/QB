using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour {

	void OnTriggerEnter(Collider col){

		if (col.GetComponent<Collider> ().tag == "cross") {
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().front = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().back = true;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().left = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().right = false;
		}


	}



}


