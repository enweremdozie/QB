using UnityEngine;
using System.Collections;

public class objectDestroyer : MonoBehaviour {
	
	float timer = 6f;//object destroy timer
	public bool collide = false;
	// Use this for initialization
	void Start () {
		dest ();
	}
		

	void Update ()
    {

	}

	void dest(){
		if (collide) {
			Destroy (gameObject);
			Debug.Log ("mesh was destroyed");
		} 
		else {
			Destroy (gameObject, timer);
		}

	}
}