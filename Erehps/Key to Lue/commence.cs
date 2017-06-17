using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class commence : MonoBehaviour {
	public GameObject[] Level1 = new GameObject[50];
	public GameObject[] Level2 = new GameObject[50];
	public GameObject[] Level3 = new GameObject[50];
	public GameObject[] Level4 = new GameObject[50];
	public GameObject[] Level5 = new GameObject[50];
	public GameObject[] Level6 = new GameObject[50];
	public GameObject[] Level7 = new GameObject[50];
	public GameObject[] Level8 = new GameObject[50];
	public GameObject[] Level9 = new GameObject[50];
	public GameObject[] Level10 = new GameObject[50];
	public GameObject[] Level11 = new GameObject[40];
	public GameObject[] Level12 = new GameObject[32];
	public GameObject[] Level13 = new GameObject[22];
	public Material black;
	public Material orig;
	int level = 13;
	int random;
	int NewLevel;
	//int Layer = 13;
	int next = 0;
	bool state = true;

	void Start(){
		random = Random.Range (7, 10);
	}
	void Update(){
		//level = GameObject.Find ("QB Parent").GetComponent<GravityScript> ().Layer;
	}

	public void initiate(){
		Debug.Log ("Coroutine started");
		StartCoroutine ("begin");
	}
	void SecondLevel(){
		Debug.Log ("Second started");
		if (level == random) {
			NewLevel = level - 2;
			if (NewLevel == 8) {
				for (int i = 0; i < 50; i++) {
					Level8 [i].GetComponent<Renderer> ().sharedMaterial = orig;
					Level8 [i].GetComponent<BoxCollider> ().enabled = false;
				}
			}
			else if (NewLevel == 7) {
				for (int i = 0; i < 50; i++) {
					Level7 [i].GetComponent<Renderer> ().sharedMaterial = orig;
					Level7 [i].GetComponent<BoxCollider> ().enabled = false;
				}
			}
			else if (NewLevel == 6) {
				for (int i = 0; i < 50; i++) {
					Level6 [i].GetComponent<Renderer> ().sharedMaterial = orig;
					Level6 [i].GetComponent<BoxCollider> ().enabled = false;
				}
			}
			else if (NewLevel == 5) {
				for (int i = 0; i < 50; i++) {
					Level5 [i].GetComponent<Renderer> ().sharedMaterial = orig;
					Level5 [i].GetComponent<BoxCollider> ().enabled = false;
				}
			}
			darkness();
			}
	

		else if (level == 13) {
			for (int i = 0; i < 22; i++) {
				Level13 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level13 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 12) {
			for (int i = 0; i < 32; i++) {
				Level12 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level12 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 11) {
			for (int i = 0; i < 40; i++) {
				Level11 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level11 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 10) {
			for (int i = 0; i < 50; i++) {
				Level10 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level10 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 9) {
			for (int i = 0; i < 50; i++) {
				Level9 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level9 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 8) {
			for (int i = 0; i < 50; i++) {
				Level8 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level8 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 7) {
			for (int i = 0; i < 50; i++) {
				Level7 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level7 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 6) {
			for (int i = 0; i < 50; i++) {
				Level6 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level6 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 5) {
			for (int i = 0; i < 50; i++) {
				Level5 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level5 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 4) {
			for (int i = 0; i < 50; i++) {
				Level4 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level4 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 3) {
			for (int i = 0; i < 50; i++) {
				Level3 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level3 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 2) {
			for (int i = 0; i < 50; i++) {
				Level2 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level2 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		else if (level == 1) {
			for (int i = 0; i < 50; i++) {
				Level1 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level1 [i].GetComponent<BoxCollider> ().enabled = true;
			}
		}
		level--;
		StartCoroutine ("delay");
	}

	void darkness(){
		NewLevel = NewLevel - 1;
		if (NewLevel == 7) {
			for (int i = 0; i < 50; i++) {
				Level7 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level7 [i].GetComponent<BoxCollider> ().enabled = true;
			}
			NewLevel--;
		}
		if (NewLevel == 6) {
			for (int i = 0; i < 50; i++) {
				Level6 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level6 [i].GetComponent<BoxCollider> ().enabled = true;
			}
			NewLevel--;
		}
		if (NewLevel == 5) {
			for (int i = 0; i < 50; i++) {
				Level5 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level5 [i].GetComponent<BoxCollider> ().enabled = true;
			}
			NewLevel--;
		}	if (NewLevel == 4) {
			for (int i = 0; i < 50; i++) {
				Level4 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level4 [i].GetComponent<BoxCollider> ().enabled = true;
			}
			NewLevel--;
		}
		if (NewLevel == 3) {
			for (int i = 0; i < 50; i++) {
				Level3 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level3 [i].GetComponent<BoxCollider> ().enabled = true;
			}
			NewLevel--;
		}
		if (NewLevel == 2) {
			for (int i = 0; i < 50; i++) {
				Level2 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level2 [i].GetComponent<BoxCollider> ().enabled = true;
			}
			NewLevel--;
		}
		if (NewLevel == 1) {
			for (int i = 0; i < 50; i++) {
				Level1 [i].GetComponent<Renderer> ().sharedMaterial = black;
				Level1 [i].GetComponent<BoxCollider> ().enabled = true;
			}
			NewLevel--;
		}

		StartCoroutine ("end");
	
	}
	void switchLevel (){
		for (int i = 0; i < 50; i++) {
			Level1 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level1 [i].GetComponent<BoxCollider> ().enabled = false;

			Level2 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level2 [i].GetComponent<BoxCollider> ().enabled = false;

			Level3 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level3 [i].GetComponent<BoxCollider> ().enabled = false;

			Level4 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level4 [i].GetComponent<BoxCollider> ().enabled = false;

			Level5 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level5 [i].GetComponent<BoxCollider> ().enabled = false;

			Level6 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level6 [i].GetComponent<BoxCollider> ().enabled = false;

			Level7 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level7 [i].GetComponent<BoxCollider> ().enabled = false;

			Level8 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level8 [i].GetComponent<BoxCollider> ().enabled = false;

			Level9 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level9 [i].GetComponent<BoxCollider> ().enabled = false;

			Level10 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level10 [i].GetComponent<BoxCollider> ().enabled = false;
		}

		for (int i = 0; i < 40; i++) {
			Level11 [i].GetComponent<Renderer> ().sharedMaterial = orig;
			Level11 [i].GetComponent<BoxCollider> ().enabled = false;
			}
		for (int j = 0; j < 32; j++) {
			Level12 [j].GetComponent<Renderer> ().sharedMaterial = orig;
			Level12 [j].GetComponent<BoxCollider> ().enabled = false;
		}
		for (int k = 0; k < 22; k++) {
			Level13 [k].GetComponent<Renderer> ().sharedMaterial = orig;
			Level13 [k].GetComponent<BoxCollider> ().enabled = false;

		}
		}
		

	IEnumerator delay(){

		yield return new WaitForSeconds (1f);
		SecondLevel ();
	}

	IEnumerator begin(){
		yield return new WaitForSeconds (5f);


		SecondLevel ();
	}

	IEnumerator end(){
		yield return new WaitForSeconds (7f);

		switchLevel ();

	}
}
