using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impact : MonoBehaviour {
	public bool collide = false;
	public bool collided = false;
	int FinalLevel = 0;
	ParticleSystem particle;
	public AudioClip collect;
	AudioSource source;
	GameObject[] Moons = new GameObject[7];


	void Awake(){
		particle = GameObject.FindGameObjectWithTag("Ed").GetComponent<ParticleSystem>();
		GameObject.Find("SwitchLevel").SetActive (false);
	}

	//for trigger events
	void OnTriggerEnter(Collider col){
		switch(col.tag){

		case"impact":

			Debug.Log ("there was a triggered collision with QB");
			break;

		case"Layer10":
			Debug.Log ("hit Layer 10");
			break;

		case"Ed":
			Debug.Log ("Found ED");
			GameObject.FindGameObjectWithTag("SwitchLevel").SetActive (true);
			GameObject.FindGameObjectWithTag ("Ed").GetComponent<MeshRenderer> ().enabled = false;
			particle.Stop ();
			Moons = GameObject.FindGameObjectsWithTag ("Moon");
			for (int i = 0; i < 7; i++) {
				Moons [i].SetActive (false);
			}
			GameObject.Find("Commence").SetActive (false);
			GameObject.Find("Origin").GetComponent<commence> ().initiate ();

			break;

		case"SwitchLevel":
			GameObject.FindGameObjectWithTag ("QB").transform.transform.position = new Vector3 (0,-10.5f,0);
			break;
		}


	}
	//for collision events
	void OnCollisionEnter(Collision col){
		switch(col.gameObject.tag){
		case"impact":

			Debug.Log ("there was a collision with QB");
			break;


		}

	}
}
