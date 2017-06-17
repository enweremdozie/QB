using UnityEngine;
using System.Collections;

public class Score2 : MonoBehaviour {

	public bool collide = false;
	public bool collided = false;

	//for trigger events
	void OnTriggerEnter(Collider col){
		switch(col.tag){
		case"minions":
			Debug.Log ("there was a triggered collision with QB");
			collide = true;
			GameObject.Find ("manager").GetComponent<GameManager2> ().QBCol(collide);
			break;

		}


	}
	//for collision events
	void OnCollisionEnter(Collision col){
		switch(col.gameObject.tag){
		case"minions":
			Debug.Log ("there was a collision with QB");
			collided = true;
			//GameObject.Find ("manager").GetComponent<GameManager2> ().col (collided);

			break;

		}

	}
}
