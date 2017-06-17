using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLayer : MonoBehaviour {
	public GameObject[] Layer2 = new GameObject[50];
	int Layer2Next = 49;
	public Material black;
	public Material orig;
	int dark = 1;
	public GameObject Layer2Cube;

	void Start () {
		change2 ();
	}
	
	void change2(){

		if (Layer2Next == -1) {
			Layer2Next = 49;
			dark++;
			if (dark == 9) {
				dark = 1;
			}

		}

		if (dark % 2 == 0) {
			Layer2Cube.SetActive (false);
			if (Layer2Next == 49) {
				Layer2Next = 48;
			}
			Layer2 [Layer2Next].GetComponent<Renderer> ().sharedMaterial = black;
			Layer2 [Layer2Next].GetComponent<BoxCollider> ().enabled = true;
		}
		else if(dark % 2 != 0) {
			Layer2Cube.SetActive (true);
			Layer2 [Layer2Next].GetComponent<Renderer> ().sharedMaterial = orig;
			Layer2 [Layer2Next].GetComponent<BoxCollider> ().enabled = false;
		}

		StartCoroutine ("Layer3Wait");
	}

	IEnumerator Layer3Wait(){
		yield return new WaitForSeconds (0.225f);
		if (Layer2Next >= 0) {
			Layer2Next--;
		}
	
		change2 ();
	}


}
