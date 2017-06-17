using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLayer : MonoBehaviour {
	public GameObject[] Layer1 = new GameObject[50];
	public Material black;
	public Material orig;
	int rand;
	int count = 0;

	void Start () {
		changeDark();
	}
	
	void changeOrig(){
		//if
		for (int i = 0; i < 50; i++) {
			Layer1 [i].GetComponent<Renderer> ().sharedMaterial = orig;
		}
		if (count < 5) {
			StartCoroutine ("waitOrig");
		}
	}

	void changeDark(){

		for (int i = 0; i < 50; i++) {
			Layer1 [i].GetComponent<Renderer> ().sharedMaterial = black;
		}
		if (count < 5) {
			StartCoroutine ("waitDark");
		}
		if (count == 5) {
			StartCoroutine ("wait");
		}
	}

	IEnumerator waitDark(){
		yield return new WaitForSeconds (0.05f);
		changeOrig ();
		count++;
	}

	IEnumerator waitOrig(){
		yield return new WaitForSeconds (0.05f);
		changeDark ();
		count++;
	}

	IEnumerator wait(){
		yield return new WaitForSeconds (1.5f);
		count = 0;
		rand = Random.Range (0, 1);
		if (rand == 0) {
			changeOrig ();
		} 
		else if (rand == 1) {
			changeDark ();
		}

	}

}
