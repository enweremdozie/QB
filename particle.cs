using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particle : MonoBehaviour {

	// Use this for initialization
	ParticleSystem particles;
	// Update is called once per frame
	void Awake () {
		particles = GetComponent<ParticleSystem> ();
	}
		
	void OnTriggerEnter(Collider col){
		switch (col.tag) {

		case"minions":
			particles.Play ();
			break;
		}
		}

}
