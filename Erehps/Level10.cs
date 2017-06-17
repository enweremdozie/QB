using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level10 : MonoBehaviour {
	public GameObject[] Last = new GameObject[50];
	public Material Orig;
	public Material black;
	public GameObject DarkMesh;
	public Transform target;
	int index = 0;
	float speed = -255f;
	Vector3 current;
	// Use this for initialization
	void Start () {
		StartCoroutine ("Dark");
	}

	// Update is called once per frame
	void Update () {
		//current = DarkMesh.transform.position;
		// = current + new Vector3 (0, 0, 0.6f);
		/*Vector3 relativePos = (target.position + new Vector3 (0, 0, 0.6f)) - DarkMesh.transform.position;	
		Quaternion rotation = Quaternion.LookRotation (relativePos);

		Quaternion current = DarkMesh.transform.localRotation;

		DarkMesh.transform.localRotation = Quaternion.Slerp (current, rotation, Time.deltaTime * 1.5f);
		DarkMesh.transform.Translate (0, 0, Time.deltaTime * 1.75f);*/
	}

	IEnumerator Red(){
		if (index == 49) {
			index = 0;
		}
		Last [index].GetComponent<Renderer> ().sharedMaterial = Orig;
		Last [index].GetComponent<BoxCollider> ().enabled = false;
		index++;
		yield return new WaitForSeconds (0.1f);
		StartCoroutine ("Dark");
	}

	IEnumerator Dark(){
		if (index == 49) {
			index = 0;
		}
			Last [index].GetComponent<Renderer> ().sharedMaterial = black;
		Last [index].GetComponent<BoxCollider> ().enabled = true;
		yield return new WaitForSeconds (0.125f);
		StartCoroutine ("Red");
	}
}

