using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	public bool collide = false;
	public bool collided = false;
	int FinalLevel = 0;
	ParticleSystem particle;
	public AudioClip collect;
	AudioSource source;

	void Awake(){
//		particle = GameObject.FindGameObjectWithTag("particles");

	}

	//for trigger events
	void OnTriggerEnter(Collider col){
		switch(col.tag){

		case"minions":
			
			Debug.Log ("there was a triggered collision with QB");
			//GameObject.FindGameObjectWithTag ("cross").GetComponent<ParticleSystem> ().Play ();
			collide = true;
			GameObject.Find ("manager").GetComponent<GameManager> ().QBCol(collide);

			break;

		}


	}
	//for collision events
	void OnCollisionEnter(Collision col){
		switch(col.gameObject.tag){
		case"minions":
			
			Debug.Log ("there was a collision with QB");
			GameObject.FindGameObjectWithTag ("cross").GetComponent<ParticleSystem> ().Play ();
			source.clip = collect;
			source.Play ();
			collided = true;
			//GameObject.Find ("particles").GetComponent<ParticleSystem> ().emission.enabled = true;

			//particle.SetActive(true);



		//	GameObject.Find ("manager").GetComponent<GameManager> ().col (collided);
			FinalLevel++;

			if(FinalLevel == 4){
				GameObject.Find ("manager").GetComponent<Xob> ().end = true;
				Application.LoadLevel (10);//load final level after collecting blue 3 times boss1end(Lue2)
			}
				break;


		}

	}
}
