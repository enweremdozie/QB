using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sides : MonoBehaviour {

	public bool collide = false;
	public bool collided = false;

	void Awake(){

	}

	//for trigger events
	void OnTriggerEnter(Collider col){

			if (col.GetComponent<Collider> ().tag == "cross") {
				Debug.Log ("WORKS");
			}


	}



}

