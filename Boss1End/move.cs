using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	void Start(){

		translating ();

	}

	void translating (){
		transform.Translate (new Vector3 (-1.694f, 0, 0));
		StartCoroutine ("wait");
	}

	IEnumerator wait(){
		yield return new WaitForSeconds (0.25f);
		translating ();
	}
}
