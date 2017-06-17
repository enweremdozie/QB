using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erehps2 : MonoBehaviour {
	public GameObject[] Layer1 = new GameObject[25];
	public GameObject[] Layer2 = new GameObject[25];
	public GameObject[] Layer3 = new GameObject[25];
	public GameObject[] Layer4 = new GameObject[25];
	public GameObject[] Layer5 = new GameObject[25];
	public GameObject[] Layer6 = new GameObject[25];
	public GameObject[] Layer7 = new GameObject[25];
	public GameObject[] Layer8 = new GameObject[25];
	public GameObject[] Layer9 = new GameObject[25];
	public GameObject[] Layer10 = new GameObject[25];
	public Material Orig;
	public Material Black;
	int index = 0;
	int Layer = 1;
	int LayerVert;
	bool Dark;
	bool NotDark;
	int VertCount;
	int count;
	int firstrandom;
	int secondrandom;
	int thirdrandom;
	int firstprev;
	int secondprev;

	// Use this for initialization
	void Awake () {
		Dark = false;
		NotDark = true;
		LayerVert = 1;
		VertCount  = 1;
		firstrandom = Random.Range (1, 5);
		secondrandom = Random.Range (1, 5);
	
		//thirdrandom = Random.Range (1, 4);
		while (secondrandom == firstrandom) {
			secondrandom = Random.Range (1, 5);
		}

		firstprev = firstrandom;
		secondprev = secondrandom;
		Debug.Log ("the first random " + firstrandom);
		Debug.Log ("the second random " + secondrandom);
		//dark();
	

	}

	void Start(){
		count = 0;
		StartCoroutine("wait");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void light(){
		if (count <= 2 || count == 10) {
		for (int i = 0; i < 25; i++) {
			Layer1 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Layer2 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Layer3 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Layer4 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Layer5 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Layer6 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Layer7 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Layer8 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Layer9 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Layer10 [i].GetComponent<Renderer> ().sharedMaterial = Orig;
		}
			if (count < 2) {
				StartCoroutine ("inter2");
			} 
			else if (count == 2) {
				StartCoroutine ("inter3");
			} 
			else if (count == 10) {
				count = 0;
				StartCoroutine ("inter5");
			}
	}
	}

	void dark(){
		if (count < 2) {
			for (int i = 0; i < 25; i++) {
				Layer1 [i].GetComponent<Renderer> ().sharedMaterial = Black;
				Layer2 [i].GetComponent<Renderer> ().sharedMaterial = Black;
				//Layer3 [i].GetComponent<Renderer> ().sharedMaterial = Black;
				Layer4 [i].GetComponent<Renderer> ().sharedMaterial = Black;
				Layer6 [i].GetComponent<Renderer> ().sharedMaterial = Black;
				Layer7 [i].GetComponent<Renderer> ().sharedMaterial = Black;
				Layer10 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			}
			for (int i = 0; i < 25; i++) {
				if (i == 7 && (firstrandom == 1 || secondrandom == 1)) {
					i = 8;
				}
				Layer3 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			}
			for (int i = 0; i < 25; i++) {
				if (i == 20 && (firstrandom == 2 || secondrandom == 2)) {
					i = 21;
				}
				Layer5 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			}
			for (int i = 0; i < 25; i++) {
				if (i == 13 && (firstrandom == 3 || secondrandom == 3)) {
					i = 14;
				}
				Layer8 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			}
			for (int i = 0; i < 25; i++) {
				if (i == 23 && (firstrandom == 4 || secondrandom == 4)) {
					i = 24;
				}
				Layer9 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			}
			if (count <= 2) {
				StartCoroutine ("inter");
			}
		}
	}

	void dark2(){
		for (int i = 0; i < 25; i++) {
			Layer1 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			Layer2 [i].GetComponent<Renderer> ().sharedMaterial = Black;
		//	Layer3 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			Layer4 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			Layer6 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			Layer7 [i].GetComponent<Renderer> ().sharedMaterial = Black;
			Layer10 [i].GetComponent<Renderer> ().sharedMaterial = Black;
		}
		for (int i = 0; i < 25; i++) {
			
			if (i == 7 && (firstrandom == 1 || secondrandom == 1)) {
				i = 8;
			}
			Layer3 [i].GetComponent<Renderer> ().sharedMaterial = Black;
		}
		for (int i = 0; i < 25; i++) {
			if (i == 20 && (firstrandom == 2 || secondrandom == 2)) {
				i = 21;
			}
			Layer5 [i].GetComponent<Renderer> ().sharedMaterial = Black;
		}
		for (int i = 0; i < 25; i++) {
			if (i == 13 && (firstrandom == 3 || secondrandom == 3)) {
				i = 14;
			}
			Layer8 [i].GetComponent<Renderer> ().sharedMaterial = Black;
		}
		for (int i = 0; i < 25; i++) {
			if (i == 23 && (firstrandom == 4 || secondrandom == 4)) {
				i = 24;
			}
			Layer9 [i].GetComponent<Renderer> ().sharedMaterial = Black;
		}
		firstrandom = Random.Range (1, 5);
		secondrandom = Random.Range (1, 5);
		//thirdrandom = Random.Range (1, 4);
		while (secondrandom == firstrandom) {
			secondrandom = Random.Range (1, 5);
		}
		Debug.Log ("the first random " + firstrandom);
		Debug.Log ("the second random " + secondrandom);
		/*while (thirdrandom == secondrandom || thirdrandom == firstrandom) {
			thirdrandom = Random.Range (2, 4);
		}*/
		while (firstrandom == firstprev || secondrandom == firstprev || firstrandom == secondprev || secondrandom == secondprev) {
			if(firstrandom == firstprev){
				firstrandom = Random.Range (1, 5);
			}
			if(secondrandom == firstprev){
				secondrandom = Random.Range (1, 5);
			}

			if(firstrandom == secondprev){
				firstrandom = Random.Range (1, 5);
			}

			if(secondrandom == secondprev){
				secondrandom = Random.Range (1, 5);
			}

		}
		firstprev = firstrandom;
		secondprev = secondrandom;
		count = 10;
			StartCoroutine ("inter4");
		
	}

	IEnumerator wait(){
		yield return new WaitForSeconds (2f);
		dark ();
	}

	IEnumerator inter(){
		yield return new WaitForSeconds (0.5f);
		count++;
		light ();
	}

	IEnumerator inter2(){
		yield return new WaitForSeconds (0.5f);

		dark();
	}

	IEnumerator inter3(){
		yield return new WaitForSeconds (1f);

		dark2();
	}

	IEnumerator inter4(){
		yield return new WaitForSeconds (7f);

		light ();
	}

	IEnumerator inter5(){
		yield return new WaitForSeconds (10f);

		dark ();
	}
}
