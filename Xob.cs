using UnityEngine;
using System.Collections;


public class Xob : MonoBehaviour{
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
	float duration = 3f;
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
	int show = 1;
	public bool end = false;
	int endCount = 0;
	public GameObject particle;

    
    // Use this for initialization
    void Awake(){
		topR = GameObject.FindGameObjectWithTag ("TR");
		botR = GameObject.FindGameObjectWithTag ("BR");
		topL = GameObject.FindGameObjectWithTag ("TL");
		botL = GameObject.FindGameObjectWithTag ("BL");

    }
		
   public void SpawnPhase1(){
		for (int i = 0; i < 8; i++) {
			genLes [i].GetComponent<Renderer> ().sharedMaterial = matOne;
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
		if (end == true) {
			endCount++;
			Debug.Log ("end count " + endCount);
		}
        pickPos = Random.Range(0, 7);
        spawnLoc = GameObject.FindGameObjectWithTag("pos4");
		for (int i = 0; i < 8; i++) {
			genLes [i].GetComponent<Renderer> ().sharedMaterial = matOne;
		}
		if (!collide) {
			//nmend = false;
			if (pickPos == 0) {//if 1
				index = 1;

				while (index <= 7) {//while 2
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
	public void FirstNM(int spawnTime){
		particle.SetActive (false);
				if(!collide){
			nm1Tracker++;

		if (spawnTime < 8 && nm1Shift == false) {
			spawnTime++;
			firstNMInterval = spawnTime;

			if (spawnTime == 8) {
				nightmare1Stop++;
				nm1Shift = true;
				spawnTime = 6;
				firstNMInterval = spawnTime;
			}
		} 
			else if (nm1Shift == true) {

		


		if (spawnTime == 0) {
				nightmare1Stop++;
				nm1Shift = false;
			}

			if (spawnTime > 0) {
				spawnTime--;
			}
			firstNMInterval = spawnTime;
		}
		
		if (qblueState == spawnTime) {
			genLes [spawnTime].GetComponent<BoxCollider> ().isTrigger = true;
		}

		/*if (spawnTime >= 8) {
			spawnTime = 0;
		}*///////////////////////////////////////////////////////////////////////////////////////
		genLes[spawnTime].GetComponent<TrailRenderer> ().enabled = false;
		genLes[spawnTime].GetComponent<Renderer> ().sharedMaterial = matTwo;
				//Debug.Log ("nightmare tracker " + nm1Tracker + "\n" + "QB find " + findQB);
				//qblueState = spawnTime;
		if (findQB == nightmare1Stop && findQB == spawnTime) {
			qblueState = spawnTime;
				genLes [spawnTime].GetComponent<BoxCollider> ().isTrigger = true;
			//genLes [spawnTime].GetComponent<TrailRenderer> ().enabled = true;
			//genLes [spawnTime].GetComponent<TrailRenderer> ().sharedMaterial = matTwo;//here**************************************
			
		} 

		


		//Debug.Log ("qbcol: " + qbcol);
	
		mesh = Instantiate (genLes [spawnTime], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
		genLes [spawnTime].GetComponent<BoxCollider> ().isTrigger = true;
			//qbcol = GameObject.Find("manager").GetComponent<GameOver>()
			
		if (qbcol) {
		Debug.Log ("found QBlue");
		qbCount++;
		qbcol = false;
		//Destroy (genLes [spawnTime]);
		}
	

		if (spawnTime++ != 8) {
			StartCoroutine ("nightMare1Int");
		}

		else {


			if (nightmareInt == false && spawnTime++ == 8) {
				spawnTime = 0;
				firstNMInterval = 0;
				GameObject.Find("manager").GetComponent<GameManager>().QBdark = false;//changes QB from dark to color
					Debug.Log (nmend);
					nmend = true;
					Debug.Log (nmend);
					SpawnPhase2 ();

			} 

			else if (nightmareInt == true && spawnTime++ == 8) {
				spawnTime = 0;
				firstNMInterval = 0;

				SecondNM ();
				}
				
			}


		}
	}
	/*********************************************secondNM****************************************************************/
	public void SecondNM(){
		//nightmare2Stop++;
		/*topR.GetComponent<Renderer> ().sharedMaterial = black;
		topL.GetComponent<Renderer> ().sharedMaterial = black;
		botR.GetComponent<Renderer> ().sharedMaterial = black;
		botL.GetComponent<Renderer> ().sharedMaterial = black;*/

		if (!collide) {
			
			nightmareInt = true;
			secNitPos = Random.Range (1, 6);
			nmpos1 = Random.Range (0, 8);
			nmpos2 = Random.Range (0, 8);


			while (nmpos1 == nmpos2) {
				nmpos2 = Random.Range (0, 8);
			}

			/*if (spawnTime == secNitPos) {
					spawnTime++;
					record++;
				}//if random position selected is same as current spawn position skip*/

			genLes [nmpos1].GetComponent<Renderer> ().sharedMaterial = matTwo;
			genLes [nmpos2].GetComponent<Renderer> ().sharedMaterial = matTwo;


		

			mesh = Instantiate (genLes [nmpos1], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
			genLes [nmpos1].GetComponent<BoxCollider> ().isTrigger = true;
			mesh = Instantiate (genLes [nmpos2], spawnLoc.transform.localPosition, Quaternion.Euler (0, 180, 0)) as GameObject;
			genLes [nmpos2].GetComponent<BoxCollider> ().isTrigger = true;
			nightmare2Stop++;

			//Debug.Log (nm2Trail);
			if (nm2Trail == 7 && show % 3 == 0) {
				nm2Trail++;
				genLes [nmpos1].GetComponent<TrailRenderer> ().enabled = true;
				genLes [nmpos1].GetComponent<TrailRenderer> ().sharedMaterial = matTwo;
				genLes [nmpos1].GetComponent<BoxCollider> ().isTrigger = false;

			} 
			else if (nm2Trail != 7) {
				nm2Trail++;
				genLes [nmpos1].GetComponent<TrailRenderer> ().enabled = false;
				genLes [nmpos1].GetComponent<TrailRenderer> ().sharedMaterial = matTwo;
				genLes [nmpos1].GetComponent<BoxCollider> ().isTrigger = true;

			}
			if (nightmare2Stop != 16) {
		
				StartCoroutine ("nightMare2Int");
			} 
			else if (nightmare2Stop == 16) {
				nightmare2Stop = 0;
				FirstNM (0);
				nmTracking++;
				nm2Trail = 0;
				show++;
			}

		}
	}

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
		FirstNM (0);

	}

	/*IEnumerator phase3()
	{
		if (inSecNit) {
			phaseThreeSpawn = 0.3f;
		}
		yield return new WaitForSeconds(phaseThreeSpawn);

		if (state) {
	           num+=1;

			if (num == 8) {
				num-=1;
				state = false;
				trackPhaThree++;

				if (trackPhaThree == 15) {
					stateThree = false;

				}

			
			}
			SpawnPhase3 (num);
		}//if

		else if (!state) {
			
			num-=1;

			if (num == -1) {
				num+=1;
				state = true;
				trackPhaThree++;

				if (trackPhaThree == 15) {
					stateThree = false;

				}

			}
			SpawnPhase3 (num);
		}//else if
	}//phase3*/

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

		if(color2Stop <= 15){
			nightmare = false;
			SpawnPhase2();
		}
		else if(color2Stop > 15){
	
			yield return new WaitForSeconds (1.5f);

			nightmare = true;
			startInterval++;
			findQB = Random.Range (2, 5);
			//nm2Trail = 0;
			FirstNM (0);
		}
	}
		
	IEnumerator nightMare1Int(){//nightmare interval
		if (!collide) {
			nightmare = true;
			yield return new WaitForSeconds (0.35f);
			//StartCoroutine("phase3");

			if (nightmare1Stop <= 4) {
			
				FirstNM (firstNMInterval);
			} else if (nightmare1Stop > 4 && startInterval < 2) {

				nightmare1Stop = 0;
				color2Stop = 0;
				yield return new WaitForSeconds (5f);
				nightmare = false;
				nmend = true;
				SpawnPhase2 ();
				//Debug.Log ("this is the spawn interval " + startInterval);
			} else if (nightmare1Stop > 4 && startInterval == 2) {
				nightmare1Stop = 0;
				nmTracking++;
				SecondNM ();
			
			}
		}//!collide
	}

	IEnumerator nightMare2Int(){//nightmare interval
		if (!collide) {
			nightmare = true;
			yield return new WaitForSeconds (0.5f);
			//StartCoroutine("phase3");
		
			SecondNM ();
		}//!collide
	}

	
}//class



