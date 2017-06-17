using UnityEngine;
using System.Collections;

public class Xob2 : MonoBehaviour {
	int pickPos;
	int secPos;
	public GameObject[] genLes = new GameObject[8];
	GameObject spawnLoc;
	GameObject mesh;
	Rigidbody obstFreeze;
	int index = 0;
	public int angry = 0;
	int angInterval = 12;
	int angpos = 0;
	// public DiscoCity discoCity;
	GameManager manage;
	public bool phase1 = true;
	public bool phase2 = false;
	float duration = 8.55f;
	public bool next = true;
	float delay = 8f;// for nightmare delay time
	bool thirdPhase = false;
	float phaseThreeSpawn = 0.5f;
	bool state = true;
	int num = 0;
	//public Material matOne;
	public Material matOne;
	public Material matTwo;
	public int trackPhaThree = 0;
	bool stateThree = false;
	public bool collide = false;
	bool stateFour = false;
	public int count = 0;
	public double record = 0;
	public bool phase4 = false;
	int secNitPos = 0;
	bool inSecNit = false;
	int nmpos1 = 0;
	int nmpos2 = 0;
	public bool level = true;
	bool nightmareInt= false;
	bool firstNight = false;
	int firstNMInterval = 0;
	bool nm1Shift = false;
	int color1Stop = 0;
	int color2Stop = 0;
	int startInterval = 0;
	public bool nightmare = false;
	int nightmare1Stop = 0;
	double nightmare2Stop = 0;
	public Color trailColor;
	int findQB = 0;
	int nmTracking = 1;
	int nm1Tracker = 0;//tracks every single minion made in nm1
	BoxCollider minion;
	public bool qbcol = false;
	int qblueState = 0;
	public int qbCount = 0;
	GameObject topR;
	GameObject topL;
	GameObject botR;
	GameObject botL;
	public Material blue;
	public Material green;
	public Material red;
	public Material yellow;
	public Material black;
	public bool nmend = false;
	public int nm2Trail = 0;
	int endCount = 0;
	public bool end = true;
	public bool beginWait = true;
	int off = 0;




	// Use this for initialization
	void Awake(){
		topR = GameObject.FindGameObjectWithTag ("TR");
		botR = GameObject.FindGameObjectWithTag ("BR");
		topL = GameObject.FindGameObjectWithTag ("TL");
		botL = GameObject.FindGameObjectWithTag ("BL");
		//off = GameObject.Find ("QB").GetComponent<QBAnimationNew> ().off;

		for (int i = 0; i < 8; i++) {
			genLes [i].GetComponent<BoxCollider> ().enabled = true;
		}

	}

	void Update(){
		//off = GameObject.Find ("QB").GetComponent<QBAnimationNew> ().off;
		//Debug.Log ("off is " + off);
	}

	public void SpawnPhase1(){
		for (int i = 0; i < 8; i++) {
			genLes [i].GetComponent<Renderer> ().sharedMaterial = matOne;
			genLes [i].GetComponent<BoxCollider> ().enabled = true;
		}


		if(!collide){
			
			pickPos = Random.Range(0, 3);
			secPos = Random.Range(0, 7);
			spawnLoc = GameObject.FindGameObjectWithTag("pos4");
			collide = GameObject.Find ("QB").GetComponent<score> ().collide;

			if (pickPos == 0){//if 1
				index = 1;

				if (secPos == 1 || secPos == 0){//if 2
					secPos = Random.Range(2, 7);
				}//if 2 end

				while (index <= 7){//while 2
					

					genLes[index].GetComponent<TrailRenderer> ().enabled = false;
					genLes[index].GetComponent<Renderer>().sharedMaterial = matOne;
					mesh = Instantiate(genLes[index], spawnLoc.transform.localPosition, Quaternion.Euler(0, 270, 0)) as GameObject;
					obstFreeze = mesh.GetComponent<Rigidbody>();
					obstFreeze.freezeRotation = true;

					index++;

					if (secPos == 2 && index == 2){
						index = 3;

					}
					else if (secPos == 3 && index == 3){
						index = 4;

					}
					else if (secPos == 4 && index == 4){
						index = 5;

					}
					else if (secPos == 5 && index == 5){
						index = 6;

					}
					else if (secPos == 6 && index == 6){
						index = 7;

					}
					else if (secPos == 7 && index == 7){
						index = 8;

					}


					if (index == 8){
						StartCoroutine("color1");//starts spawn over for next wave of obstacles each time
					}//if

				}//while 2 end

			}//if 1 ends

			else if (pickPos == 1){//if 2
				index = 0;

				if (secPos == 0 || secPos == 1 || secPos == 2){
					secPos = Random.Range(3, 7);
				}//if 2  
				// print(pickPos + " this is the first position");
				// print(secPos + " this is the second position");

				while (index <= 7){//while 3

					mesh = Instantiate(genLes[index], spawnLoc.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
					obstFreeze = mesh.GetComponent<Rigidbody>();
					obstFreeze.freezeRotation = true;

					index++;
					if(index == 1){
						index++;
					}
					if (secPos == 3 && index == 3){
						index = 4;
					}
					else if (secPos == 4 && index == 4){
						index = 5;
					}
					else if (secPos == 5 && index == 5){
						index = 6;
					}
					else if (secPos == 6 && index == 6){
						index = 7;
					}
					else if (secPos == 7 && index == 7){
						index = 8;
					}

					if (index == 8){
						StartCoroutine("color1");//starts spawn over for next wave of obstacles each time
					}//if

				}//while 3 end

			}//if 2

			else if (pickPos == 2){//if 3
				index = 0;

				if (secPos == 1 || secPos == 2 || secPos == 3){
					secPos = Random.Range(4, 7);
				}//if 2  

				//   print(pickPos + " this is the first position");
				//  print(secPos + " this is the second position");

				if (secPos == 0){
					index++;
				}

				while (index <= 7)
				{//while 4
					
					genLes[index].GetComponent<TrailRenderer> ().enabled = false;
					genLes[index].GetComponent<Renderer>().sharedMaterial = matOne;
					mesh = Instantiate(genLes[index], spawnLoc.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
					obstFreeze = mesh.GetComponent<Rigidbody>();
					obstFreeze.freezeRotation = true;

					index++;


					if (index == 2){
						index++;
					}

					if (secPos == 0 && index == 0){
						index = 1;
					}
					else if (secPos == 4 && index == 4){
						index = 5;
					}
					else if (secPos == 5 && index == 5){
						index = 6;
					}
					else if (secPos == 6 && index == 6){
						index = 7;
					}
					else if (secPos == 7 && index == 7){
						index = 8;
					}

					if (index == 8){
						StartCoroutine("color1");//starts spawn over for next wave of obstacles each time
					}//if 

				}//while 4 end

			}//if 3


			else if (pickPos == 3){//if 4
				index = 0;

				if (secPos == 2 || secPos == 3 || secPos == 4){
					secPos = Random.Range(5, 7);
				}//if 2  

				//  print(pickPos + " this is the first position");
				// print(secPos + " this is the second position");

				if (secPos == 0 || secPos == 1){
					index++;
				}

				while (index <= 7){// while 5
					
					genLes[index].GetComponent<TrailRenderer> ().enabled = false;
					genLes[index].GetComponent<Renderer>().sharedMaterial = matOne;
					mesh = Instantiate(genLes[index], spawnLoc.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
					obstFreeze = mesh.GetComponent<Rigidbody>();
					obstFreeze.freezeRotation = true;

					index++;


					if (index == 3){
						index++;
					}

					if (secPos == 0 && index == 0){
						index = 1;
					}
					else if (secPos == 1 && index == 1){
						index = 2;
					}
					else if (secPos == 5 && index == 5){
						index = 6;
					}
					else if (secPos == 6 && index == 6){
						index = 7;
					}
					else if (secPos == 7 && index == 7){
						index = 8;
					}

					if (index == 8){
						StartCoroutine("waitSomeTime");//starts spawn over for next wave of obstacles each time
					}//if 

				}//while 5 end

			}//if 4
		}//!collide

	}//SpawnPhase1


	/********************************************************************************SpawnPhase2**********************************************************************/
	public void SpawnPhase2(){
		if (off == 12) {///////////////////////////////////////////over here///////////////////////////////////////////////////////for ending boss1
			collide = true;
			Application.LoadLevel (2);
		}
		for (int i = 0; i < 8; i++) {
			genLes [i].GetComponent<BoxCollider> ().enabled = true;
		}

		 if (end == true) {
			endCount++;
			Debug.Log ("end count " + endCount);
		}
		pickPos = Random.Range(0, 7);
		spawnLoc = GameObject.FindGameObjectWithTag("pos4");
		for (int i = 0; i < 8; i++) {
			genLes [i].GetComponent<Renderer> ().sharedMaterial = matOne;

		}

		off++;//for ending game after 10 times
		Debug.Log ("off for game end is: " + off);

			if (beginWait == true) {
				StartCoroutine ("wait");
			}

		else if (!collide) {
			//nmend = false;
			if (pickPos == 0) {//if 1
		
				index = 1;

				while (index <= 7) {//while 2
					
					//genLes [index].GetComponent<MeshRenderer>().enabled = false;
					genLes [index].GetComponent<TrailRenderer> ().enabled = false;
					genLes [index].GetComponent<Renderer> ().sharedMaterial = matOne;
					mesh = Instantiate (genLes [index], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
					genLes [index].GetComponent<BoxCollider> ().isTrigger = true;
					obstFreeze = mesh.GetComponent<Rigidbody> ();
					obstFreeze.freezeRotation = true;

					index++;

					if (index == 8) {
						StartCoroutine ("color2");//starts spawn over for next wave of obstacles each time
					}//if

				}//while 2 end

			}//if 1 ends

			else if (pickPos == 1) {//if 2
				index = 0;



				while (index <= 7) {//while 3
					
					//genLes [index].GetComponent<MeshRenderer>().enabled = false;
					genLes [index].GetComponent<TrailRenderer> ().enabled = false;
					genLes [index].GetComponent<Renderer> ().sharedMaterial = matOne;
					mesh = Instantiate (genLes [index], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
					genLes [index].GetComponent<BoxCollider> ().isTrigger = true;
					obstFreeze = mesh.GetComponent<Rigidbody> ();
					obstFreeze.freezeRotation = true;

					index++;

					if (index == 1) {
						index++;
					}


					if (index == 8) {
						StartCoroutine ("color2");//starts spawn over for next wave of obstacles each time
					}//if

				}//while 3 end

			}//if 2

			else if (pickPos == 2) {//if 3
				index = 0;

				while (index <= 7) {//while 4
					
					//genLes [index].GetComponent<MeshRenderer>().enabled = false;
					genLes [index].GetComponent<TrailRenderer> ().enabled = false;
					genLes [index].GetComponent<Renderer> ().sharedMaterial = matOne;
					mesh = Instantiate (genLes [index], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
					genLes [index].GetComponent<BoxCollider> ().isTrigger = true;
					obstFreeze = mesh.GetComponent<Rigidbody> ();
					obstFreeze.freezeRotation = true;

					index++;


					if (index == 2) {
						index++;
					}


					if (index == 8) {
						StartCoroutine ("color2");//starts spawn over for next wave of obstacles each time
					}//if 

				}//while 4 end

			}//if 3


			else if (pickPos == 3) {//if 4
				index = 0;

				while (index <= 7) {// while 5
					
					//genLes [index].GetComponent<MeshRenderer>().enabled = false;
					genLes [index].GetComponent<TrailRenderer> ().enabled = false;
					genLes [index].GetComponent<Renderer> ().sharedMaterial = matOne;
					mesh = Instantiate (genLes [index], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
					genLes [index].GetComponent<BoxCollider> ().isTrigger = true;
					obstFreeze = mesh.GetComponent<Rigidbody> ();
					obstFreeze.freezeRotation = true;

					index++;


					if (index == 3) {
						index++;
					}

					if (index == 8) {
						StartCoroutine ("color2");//starts spawn over for next wave of obstacles each time
					}//if 

				}//while 5 end

			}//if 4

			else if (pickPos == 4) {//if 4
				index = 0;

				while (index <= 7) {// while 5
					
					//genLes [index].GetComponent<MeshRenderer>().enabled = false;
					genLes [index].GetComponent<TrailRenderer> ().enabled = false;
					genLes [index].GetComponent<Renderer> ().sharedMaterial = matOne;
					mesh = Instantiate (genLes [index], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
					genLes [index].GetComponent<BoxCollider> ().isTrigger = true;
					obstFreeze = mesh.GetComponent<Rigidbody> ();
					obstFreeze.freezeRotation = true;

					index++;


					if (index == 4) {
						index++;
					}

					if (index == 8) {
						StartCoroutine ("color2");//starts spawn over for next wave of obstacles each time
					}//if 

				}//while end

			}//if 

			else if (pickPos == 5) {//if 4
				index = 0;

				while (index <= 7) {// while 5
					
					//genLes [index].GetComponent<MeshRenderer>().enabled = false;
					genLes [index].GetComponent<TrailRenderer> ().enabled = false;
					genLes [index].GetComponent<Renderer> ().sharedMaterial = matOne;
					mesh = Instantiate (genLes [index], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
					genLes [index].GetComponent<BoxCollider> ().isTrigger = true;
					obstFreeze = mesh.GetComponent<Rigidbody> ();
					obstFreeze.freezeRotation = true;

					index++;


					if (index == 5) {
						index++;
					}

					if (index == 8) {
						StartCoroutine ("color2");//starts spawn over for next wave of obstacles each time
					}//if 

				}//while 5 end

			}//if 4

			else if (pickPos == 6) {//if 4
				index = 0;

				while (index <= 7) {// while 5
					
					//genLes [index].GetComponent<MeshRenderer>().enabled = false;
					genLes [index].GetComponent<TrailRenderer> ().enabled = false;
					genLes [index].GetComponent<Renderer> ().sharedMaterial = matOne;
					mesh = Instantiate (genLes [index], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
					genLes [index].GetComponent<BoxCollider> ().isTrigger = true;
					obstFreeze = mesh.GetComponent<Rigidbody> ();
					obstFreeze.freezeRotation = true;

					index++;


					if (index == 6) {
						index++;
					}

					if (index == 8) {
						StartCoroutine ("color2");//starts spawn over for next wave of obstacles each time
					}//if 

				}//while 5 end

			}//if 4

			else if (pickPos == 7) {//if 4
				index = 0;

				while (index <= 7) {// while 5
					
					genLes [index].GetComponent<MeshRenderer>().enabled = false;
					genLes [index].GetComponent<TrailRenderer> ().enabled = false;
					genLes [index].GetComponent<Renderer> ().sharedMaterial = matOne;
					mesh = Instantiate (genLes [index], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
					genLes [index].GetComponent<BoxCollider> ().isTrigger = true;
					obstFreeze = mesh.GetComponent<Rigidbody> ();
					obstFreeze.freezeRotation = true;

					index++;


					if (index == 7) {
						index++;
					}

					if (index == 8) {
						StartCoroutine ("color2");//starts spawn over for next wave of obstacles each time
					}//if 

				}//while 5 end

			}//if 4

		}//!collide
	}//SpawnPhase2


	/******************************************************************************new nm1*****************************************/

	IEnumerator waitSomeTime(){
		angry++;
		yield return new WaitForSeconds(duration);
		//angry = 15;
		if (phase4 == true) {
			//GameObject.Find ("manager").GetComponent<GameManager> ().phaseTwo (0);
			phase4 = false;
			duration = 3f;
			angry = 0;
		}

		if (angry == 13 && phase2 == false){
			angry = 1;
			phase2 = true;
			phase1 = false;

		}

		if (phase1){
			SpawnPhase1();
		}

		if (angry == 15){//begin nightmare1
			firstNight = true;
			phase2 = false;
			stateThree = true;
			StartCoroutine ("delayTime");
		}

		else if (phase2){
			SpawnPhase2();
		}


	}//IEnumerator


	IEnumerator delayTime(){

		yield return new WaitForSeconds(delay);
		next = false;
		//FirstNM (0);

	}

	IEnumerator wait()
	{
		
		yield return new WaitForSeconds(2f);
		beginWait = false;
		SpawnPhase2 ();

	}//phase3

	IEnumerator color1(){//nightmare interval
		color1Stop++;
		yield return new WaitForSeconds (duration);

		if(color1Stop <= 12){
			SpawnPhase1();
		}
		else if(color1Stop > 12){
			SpawnPhase2();
		}
	}

	IEnumerator color2(){//nightmare interval
		color2Stop++;
		yield return new WaitForSeconds (duration);

		//if(color2Stop <= 15){
			nightmare = false;
			SpawnPhase2();
		//}
		/*else if(color2Stop > 15){

			yield return new WaitForSeconds (1.5f);

			nightmare = true;
			startInterval++;
			findQB = Random.Range (2, 5);
			//nm2Trail = 0;
			//FirstNM (0);
		}*/
	}



}//class



