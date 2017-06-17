using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level13 : MonoBehaviour {
	public GameObject[] Last = new GameObject[22];
	public Material Orig;
	public Material black;
	// Use this for initialization
	void Start () {
		StartCoroutine ("red");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator red(){
		for (int i = 0; i < 22; i++) {
			Last [i].GetComponent<Renderer> ().sharedMaterial = Orig;
			Last[i].GetComponent<BoxCollider> ().enabled = false;
		}
		yield return new WaitForSeconds (3f);
		StartCoroutine ("dark");
	}

	IEnumerator dark(){
		for (int i = 0; i < 22; i++) {
			Last [i].GetComponent<Renderer> ().sharedMaterial = black;
			Last[i].GetComponent<BoxCollider> ().enabled = true;
		}
		yield return new WaitForSeconds (5f);
		StartCoroutine ("red");
	}
}
