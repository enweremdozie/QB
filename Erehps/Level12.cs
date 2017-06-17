using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level12 : MonoBehaviour {
	public GameObject[] Last = new GameObject[32];
	public Material Orig;
	public Material black;
	// Use this for initialization
	void Start () {
		StartCoroutine ("dark");
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator red(){
		for (int i = 0; i < 32; i++) {
			Last [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Last[i].GetComponent<BoxCollider> ().enabled = false;
		}
		yield return new WaitForSeconds (3f);
		StartCoroutine ("dark");
	}

	IEnumerator dark(){
		for (int i = 0; i < 32; i++) {
			Last [i].GetComponent<Renderer> ().sharedMaterial = black;
			Last[i].GetComponent<BoxCollider> ().enabled = true;
		}
		yield return new WaitForSeconds (4f);
		StartCoroutine ("red");
	}
}
