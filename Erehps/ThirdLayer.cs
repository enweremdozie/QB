using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdLayer : MonoBehaviour {
	public GameObject[] Layer1 = new GameObject[50];
	/*public GameObject[] Layer2 = new GameObject[50];*/
	public GameObject[] Layer3 = new GameObject[50];
	public Material black;
	public Material orig;
	int Layer3Next = 2;
	public GameObject Layer1Cube;
	public GameObject Layer3Cube;

	void Start(){
		for (int i = 0; i <= 49; i++) {
			Layer1[i].GetComponent<Renderer>().sharedMaterial = black;
			Layer1 [i].GetComponent<BoxCollider> ().enabled = true;
		}

		change3 ();
	}
	void change3(){
		Layer3Cube.SetActive (false);
		Layer1Cube.SetActive (true);
		if (Layer3Next == 49) {
			for (int i = 0; i <= 49; i++) {
				Layer3[i].GetComponent<Renderer>().sharedMaterial = orig;
				Layer3[i].GetComponent<BoxCollider> ().enabled = false;
			}
			Layer3Next = 2;
		}
		Layer3[Layer3Next].GetComponent<Renderer>().sharedMaterial = black;
		Layer3 [Layer3Next].GetComponent<BoxCollider> ().enabled = true;

		StartCoroutine ("Layer3Wait");
	}

	IEnumerator Layer3Wait(){
		yield return new WaitForSeconds (0.25f);
		Layer3Next++;
		if (Layer3Next == 49) {
			yield return new WaitForSeconds (0.75f);
			Layer1Cube.SetActive (false);
			Layer3Cube.SetActive (true);
			for (int i = 0; i <= 49; i++) {
				Layer3[i].GetComponent<Renderer>().sharedMaterial = black;
				Layer3 [i].GetComponent<BoxCollider> ().enabled = true;
				Layer1[i].GetComponent<Renderer>().sharedMaterial = orig;
				Layer1[i].GetComponent<BoxCollider> ().enabled = false;

				}

			yield return new WaitForSeconds (0.75f);
			Layer1Cube.SetActive (false);
			for (int i = 0; i <= 49; i++) {
				Layer1[i].GetComponent<Renderer>().sharedMaterial = black;
				Layer1[i].GetComponent<BoxCollider> ().enabled = true;
				Layer3[i].GetComponent<Renderer>().sharedMaterial = orig;
				Layer3[i].GetComponent<BoxCollider> ().enabled = false;
			}
			yield return new WaitForSeconds (0.50f);//takes 13.75 seconds
		}


		change3 ();

	}
}
