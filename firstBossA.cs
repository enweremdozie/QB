using UnityEngine;
using System.Collections;


public class firstBossA : MonoBehaviour {
	int pickPos;
	int secPos;
	public GameObject[] genLes = new GameObject[8];
	GameObject spawnLoc;
	GameObject mesh;
	Rigidbody obstFreeze;
	int index = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine("waitSomeTime");

	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void spawn(){
		pickPos = Random.Range(0,3);
		secPos = Random.Range(0,8);
		spawnLoc = GameObject.FindGameObjectWithTag ("pos4");
		//index = 1;


		if(pickPos == 0){//if 1
			index = 1;

			if(secPos == 1){
				secPos = Random.Range(2,7);
			}//if 2  
			print(pickPos + " this is the first position");
			print(secPos + " this is the second position");
					while(index <= 7){
					    mesh = Instantiate(genLes[index], spawnLoc.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
						obstFreeze = mesh.GetComponent<Rigidbody>();
						obstFreeze.freezeRotation = true;

						index++;
				    if(secPos == 2 && index == 2){
					    index = 3;
				    }
					else if(secPos == 3 && index == 3){
						index = 4;
					}
					else if(secPos == 4 && index == 4){
						index = 5;
				    }
					else if(secPos == 5 && index == 5){
						index = 6;
					}
					else if(secPos == 6 && index == 6){
						index = 7;
					}
					else if(secPos == 7 && index == 7){
						index = 8;
					}
									
				if(index == 8){
						StartCoroutine("waitSomeTime");//starts spawn over for next wave of obstacles each time
							  }//if

				}//while

			 

					

		        		 }//if 1





		else if(pickPos == 1){//if 2
			index = 0;
			
			if(secPos == 0 || secPos == 1 || secPos == 2){
				secPos = Random.Range(3,8);
			}//if 2  
			print(pickPos + " this is the first position");
			print(secPos + " this is the second position");
			
			while(index <= 7){
				mesh = Instantiate(genLes[index], spawnLoc.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
				obstFreeze = mesh.GetComponent<Rigidbody>();
				obstFreeze.freezeRotation = true;
				
				index++;

				if(index == 1){
					index++;
				}

				if(secPos == 3 && index == 3){
					index = 4;
				}
				else if(secPos == 4 && index == 4){
					index = 5;
				}
				else if(secPos == 5 && index == 5){
					index = 6;
				}
				else if(secPos == 6 && index == 6){
					index = 7;
				}
				else if(secPos == 7 && index == 7){
					index = 8;
				}
				
				if(index == 8){
					StartCoroutine("waitSomeTime");//starts spawn over for next wave of obstacles each time
				}//if
				
			}//while
			
			
			
			
			
		}//if 2





		else if(pickPos == 2){//if 3
			index = 0;
			
			if(secPos == 1 || secPos == 2 || secPos == 3){
				secPos = Random.Range(4,8);
			}//if 2  

			print(pickPos + " this is the first position");
			print(secPos + " this is the second position");

			if(secPos == 0)
			{
				index++;
			}

			while(index <= 7){
				mesh = Instantiate(genLes[index], spawnLoc.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
				obstFreeze = mesh.GetComponent<Rigidbody>();
				obstFreeze.freezeRotation = true;
				
				index++;
				
				/*if(secPos ==  && index == 0){
					index = 2;
				}*/
				if(index == 2){
					index++;
				}

				if(secPos == 0 && index == 0){
					index = 1;
				}
				else if(secPos == 4 && index == 4){
					index = 5;
				}
				else if(secPos == 5 && index == 5){
					index = 6;
				}
				else if(secPos == 6 && index == 6){
					index = 7;
				}
				else if(secPos == 7 && index == 7){
					index = 8;
				}
				
				if(index == 8){
					StartCoroutine("waitSomeTime");//starts spawn over for next wave of obstacles each time
				}//if 
				
			}//while
			
			
			
			
			
		}//if 3



		else if(pickPos == 3){//if 4
			index = 0;
			
			if(secPos == 2 || secPos == 3 || secPos == 4){
				secPos = Random.Range(5,8);
			}//if 2  

			print(pickPos + " this is the first position");
			print(secPos + " this is the second position");

			if(secPos == 0 || secPos == 1)
			{
				index++;
			}
			
			while(index <= 7){
				mesh = Instantiate(genLes[index], spawnLoc.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
				obstFreeze = mesh.GetComponent<Rigidbody>();
				obstFreeze.freezeRotation = true;
				
				index++;
				
				/*if(secPos ==  && index == 0){
					index = 2;
				}*/
				if(index == 3){
					index++;
				}
				
				if(secPos == 0 && index == 0){
					index = 1;
				}
				else if(secPos == 1 && index == 1){
					index = 2;
				}
				else if(secPos == 5 && index == 5){
					index = 6;
				}
				else if(secPos == 6 && index == 6){
					index = 7;
				}
				else if(secPos == 7 && index == 7){
					index = 8;
				}
				
				if(index == 8){
					StartCoroutine("waitSomeTime");//starts spawn over for next wave of obstacles each time
				}//if 
				
			}//while
			
			
			
			
			
		}//if 4



				}//spawn


	IEnumerator waitSomeTime() {
		
		yield return new WaitForSeconds(3);
		spawn();

	}//IEnumerator
	

		}//class

	

				