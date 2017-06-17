using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Front : MonoBehaviour {

	void OnTriggerEnter(Collider col){

		if (col.GetComponent<Collider> ().tag == "cross") {
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().front = true;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().back = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().left = false;
			GameObject.Find ("QB Parent").GetComponent<GravityScript> ().right = false;


		}


	}



}

