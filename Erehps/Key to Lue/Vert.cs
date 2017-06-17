using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vert : MonoBehaviour {
	public GameObject[] Layer1 = new GameObject[10];
	public GameObject[] Layer2 = new GameObject[10];
	public GameObject[] Layer3 = new GameObject[10];
	public GameObject[] Layer4 = new GameObject[10];
	public GameObject[] Layer5 = new GameObject[10];
	public GameObject[] Layer6 = new GameObject[10];
	public GameObject[] Layer7 = new GameObject[10];
	public GameObject[] Layer8 = new GameObject[10];
	public GameObject[] Layer9 = new GameObject[10];
	public GameObject[] Layer10 = new GameObject[10];
	public GameObject[] Layer11 = new GameObject[10];
	public GameObject[] Layer12 = new GameObject[10];
	public GameObject[] Layer13 = new GameObject[10];
	public GameObject[] Layer14 = new GameObject[10];
	public GameObject[] Layer15 = new GameObject[10];
	public GameObject[] Layer16 = new GameObject[10];
	public GameObject[] Layer17 = new GameObject[10];
	public GameObject[] Layer18 = new GameObject[10];
	public GameObject[] Layer19 = new GameObject[10];
	public GameObject[] Layer20 = new GameObject[10];
	public GameObject[] Layer21 = new GameObject[10];
	public GameObject[] Layer22 = new GameObject[10];
	public GameObject[] Layer23 = new GameObject[10];
	public GameObject[] Layer24 = new GameObject[10];
	public GameObject[] Layer25 = new GameObject[10];

	public Material dark;
	public Material orig;

	int[] current = new int[25]; 
	int[] previous = new int[25];
	int[] next = new int[25];
	int layer;
	int firstrandom;
	int secondrandom;
	int thirdrandom;
	int count;
	int ChooseRan;
	int choose;
	int location;
	int RealRandom;
	int ChooseRanPrev;

	float duration = 3f;

	bool check = false;

	bool color = true;
	bool state = false;
	// Use this for initialization
	void Start () {
		
		ChooseRan = 5;
		ChooseRanPrev = ChooseRan;
		RealRandom = Random.Range (0, 1);
		location = 20;
		duration = 0.5f;
		current [19] = 5;
		StartCoroutine ("intermission");
	}

	void Original(){

	}
	void Dark20Start(){
		
		for (int i = 0; i < 10; i++) {
			if (i == current[19]) {
				i = current[19] + 1;
			}
			Layer20 [i].GetComponent<Renderer> ().sharedMaterial = dark;

		}
		current [20] = current[19];
		StartCoroutine ("wait");
	}

	void Dark20(){
		//previous[19] = current[19];
		RealRandom = Random.Range (0, 2);
		Debug.Log ("Real Random " + RealRandom);

		if (next [19] == 9 && RealRandom == 1) {
			next[19] = next[19] - 1;
		} 
		else if (next[19] == 2 && RealRandom == 0) {
			next[19] = next[19] + 1;
		}
		else if (RealRandom == 0 && next[19] > 1) {
			//ChooseRan = ChooseRan - 1;
			//Layer20 [ChooseRanPrev].GetComponent<Renderer> ().sharedMaterial = orig;
		//	Layer20 [current[19] + 1].GetComponent<Renderer> ().sharedMaterial = dark;
			next[19] = current[19] - 1;
		}
		else if(RealRandom == 1 && next[19] < 10){
			//Layer20 [ current[19] - 1].GetComponent<Renderer> ().sharedMaterial = orig;
			next[19] = current[19] + 1;
		}


		for (int i = 0; i < 10; i++) {
			/*if ((i == current[19] && (i + 1) == next[19]) || (i == current[19] && (i - 1) == next[19]) && (i != 9)) {
				i = i + 1;
			}*/
			Layer20 [i].GetComponent<Renderer> ().sharedMaterial = dark;
			Layer20[current[19]].GetComponent<Renderer> ().sharedMaterial = orig;
			Layer20[next[19]].GetComponent<Renderer> ().sharedMaterial = orig;
		}

		//location = 20;
		//Debug.Log("this is 19 " + next[19]);

		current [20] = current[19];
		next [20] = next[19];
		current [19] = next [19];

		StartCoroutine ("wait");
	}

	void Dark21(int darken){

		for (int i = 0; i < 10; i++) {
			if (i == current[20] || i == next[20]) {
				i = i + 1;
			}
			Layer21 [i].GetComponent<Renderer> ().sharedMaterial = dark;
			Layer21[current[20]].GetComponent<Renderer> ().sharedMaterial = orig;
			Layer21[next[20]].GetComponent<Renderer> ().sharedMaterial = orig;
		}
		location = 21;
		current [21] = current[20];
		next [21] = next [20];
		Dark20 ();
	}

	void Dark22(int darken){
		Debug.Log ("we are in 22");
		for (int i = 0; i < 10; i++) {
			if (i == current[21] || i == next[21]) {
				i = i + 1;
			}
			Layer22 [i].GetComponent<Renderer> ().sharedMaterial = dark;
			Layer22[current[20]].GetComponent<Renderer> ().sharedMaterial = orig;
			Layer22[next[20]].GetComponent<Renderer> ().sharedMaterial = orig;
		}
		location = 20;
		Dark20();
	}

	void Dark23(int darken){

	}

	void Dark24(int darken){

	}

	void Dark25(int darken){

	}

	void Dark1(int darken){

	}

	void Dark2(int darken){

	}

	void Dark3(int darken){

	}
		
	void Dark4(int darken){

	}

	void Dark5(int darken){

	}

	void Dark6(int darken){

	}

	void Dark7(int darken){

	}

	void Dark8(int darken){

	}

	void Dark9(int darken){

	}

	void Dark10(int darken){

	}

	void Dark11(int darken){

	}

	void Dark12(int darken){

	}

	void Dark13(int darken){

	}

	void Dark14(int darken){

	}

	void Dark15(int darken){

	}

	void Dark16(int darken){

	}

	void Dark17(int darken){

	}

	void Dark18(int darken){

	}

	void Dark19(int darken){

	}













	IEnumerator wait(){
		//RealRandom = Random.Range (0, 1);
		yield return new WaitForSeconds (duration);

		if (location == 20) {
			Dark21 (ChooseRan);
		}
		else if (location == 21) {
			Dark22 (ChooseRan);
		}
		else if (location == 22) {
			Dark23 (ChooseRan);
		}
		else if (location == 23) {
			Dark24 (ChooseRan);
		}
		else if (location == 24) {
			Dark25 (ChooseRan);
		}

		else if (location == 25) {
			Dark1 (ChooseRan);
		}
		else if (location == 1) {
			Dark2 (ChooseRan);
		}
		else if (location == 2) {
			Dark3 (ChooseRan);
		}
		else if (location == 3) {
			Dark4 (ChooseRan);
		}
		else if (location == 4) {
			Dark5 (ChooseRan);
		}
		else if (location == 5) {
			Dark6 (ChooseRan);
		}
		else if (location == 6) {
			Dark7 (ChooseRan);
		}
		else if (location == 7) {
			Dark8 (ChooseRan);
		}
		else if (location == 8) {
			Dark9 (ChooseRan);
		}
		else if (location == 9) {
			Dark10 (ChooseRan);
		}
		else if (location == 10) {
			Dark11 (ChooseRan);
		}
		else if (location == 11) {
			Dark12 (ChooseRan);
		}
		else if (location == 12) {
			Dark13 (ChooseRan);
		}
		else if (location == 13) {
			Dark14 (ChooseRan);
		}
		else if (location == 14) {
			Dark15 (ChooseRan);
		}
		else if (location == 15) {
			Dark16 (ChooseRan);
		}
		else if (location == 16) {
			Dark17 (ChooseRan);
		}
		else if (location == 17) {
			Dark18 (ChooseRan);
		}
		else if (location == 18) {
			Dark19 (ChooseRan);
		}

	}

	IEnumerator intermission(){
		yield return new WaitForSeconds (1f);
		Dark20();

		//ChooseRan = Random.Range (1, 4);
	}

	IEnumerator intermission2(){
		yield return new WaitForSeconds (1f);
	}
}
