using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {
	//public Rigidbody obstacle1;
	public Transform spawn;
	bool state = true;
	float speed = 2;
	float rate = 3;
	float next = 0;
	float del = 0;
	public GameObject[] obstacles = new GameObject[16];
	int number;
	int randNum;
	GameObject currObstacle;
	Rigidbody obstFreeze;
	int colObst;//for deciding when a colored obstacle should be chosen
	int choCol;//for deciding which colored obstacle is chosen
	ConstantForce getForce;
	public Material[] materials = new Material[24];
	public Material[] materialOne = new Material[24];
	public Material[] materialTwo = new Material[24];
	public Material[] materialThree = new Material[24];
	public Material[] materialFour = new Material[24];
	public Material[] materialFive = new Material[24];
	public Material[] materialSix = new Material[24];
	public Material[] materialSeven = new Material[24];
	public Material[] materialEight = new Material[24];
	
	GameObject[] lWall = new GameObject[14];
	
	GameObject[] rWall = new GameObject[14];
	
	GameObject[] tWall = new GameObject[14];
	
	GameObject[] bWall = new GameObject[14];
	
	Renderer rend;
	
	int wall = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		createObstacles();
	}
	
	
	void createObstacles(){
		GameObject obstacle;
		lWall = GameObject.FindGameObjectsWithTag("discoLef");
		rWall = GameObject.FindGameObjectsWithTag("discoRig");
		tWall = GameObject.FindGameObjectsWithTag("discoTop");
		bWall = GameObject.FindGameObjectsWithTag("discoBot");
		
		
		number = Random.Range(0,7);
		colObst = Random.Range(0,5);
		choCol = Random.Range (8,15);
		
		
		if(colObst != 0 && state && Time.time > next){//if colObst = 0 spawn a colored obstacle
			next = Time.time + rate;
			currObstacle = obstacles[choCol];
			obstacle = Instantiate(currObstacle, spawn.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
			obstFreeze = obstacle.GetComponent<Rigidbody>();
			
			obstFreeze.freezeRotation = true;
			//getForce = obstacle.GetComponent<ConstantForce>();
			//getForce.GetComponent<ConstantForce>().force = new Vector3(-20, 0, 0);
			//obstacle.GetComponent<Rigidbody>().AddForce(spawn.forward * 500);
			
			if((number == 0 && colObst != 0) || (choCol == 8 && colObst == 0)){
				bWall = GameObject.FindGameObjectsWithTag("discoBot");
				
				for(int i = 0; i < 14; i++){//places QB move position material
					randNum = Random.Range(0,23);
					rend = bWall[i].GetComponent<Renderer>();
					//bWall[i].GetComponent<Renderer>().material = material0[Random.Range(0,23)];
					rend.material = materialOne[randNum];
					
					Debug.Log("we are in bWall");
				}
				
			}//if
			
			else if((number == 1 && colObst != 0) || (choCol == 9 && colObst == 0)){
				bWall = GameObject.FindGameObjectsWithTag("discoBot");
				
				for(int i = 0; i < 14; i++){//places QB move position material
					randNum = Random.Range(0,23);
					rend = bWall[i].GetComponent<Renderer>();
					//bWall[i].GetComponent<Renderer>().material = material0[Random.Range(0,23)];
					rend.material = materialTwo[randNum];
					Debug.Log("we are in bWall");
				}
				
			}// else if
			
			else if((number == 2 && colObst != 0) || (choCol == 10 && colObst == 0)){
				bWall = GameObject.FindGameObjectsWithTag("discoBot");
				
				for(int i = 0; i < 14; i++){//places QB move position material
					randNum = Random.Range(0,23);
					rend = bWall[i].GetComponent<Renderer>();
					//bWall[i].GetComponent<Renderer>().material = material0[Random.Range(0,23)];
					rend.material = materialThree[randNum];
					Debug.Log("we are in bWall");
				}
				
			}// else if
			
			else if((number == 3 && colObst != 0) || (choCol == 11 && colObst == 0)){
				bWall = GameObject.FindGameObjectsWithTag("discoBot");
				
				for(int i = 0; i < 14; i++){//places QB move position material
					randNum = Random.Range(0,23);
					rend = bWall[i].GetComponent<Renderer>();
					//bWall[i].GetComponent<Renderer>().material = material0[Random.Range(0,23)];
					rend.material = materialFour[randNum];
					Debug.Log("we are in bWall");
				}
				
			}// else if
			
			else if((number == 4 && colObst != 0) || (choCol == 12 && colObst == 0)){
				bWall = GameObject.FindGameObjectsWithTag("discoBot");
				
				for(int i = 0; i < 14; i++){//places QB move position material
					randNum = Random.Range(0,23);
					rend = bWall[i].GetComponent<Renderer>();
					//bWall[i].GetComponent<Renderer>().material = material0[Random.Range(0,23)];
					rend.material = materialFive[randNum];
					Debug.Log("we are in bWall");
				}
				
			}// else if
			
			else if((number == 5 && colObst != 0) || (choCol == 13 && colObst == 0)){
				bWall = GameObject.FindGameObjectsWithTag("discoBot");
				
				for(int i = 0; i < 14; i++){//places QB move position material
					randNum = Random.Range(0,23);
					rend = bWall[i].GetComponent<Renderer>();
					//bWall[i].GetComponent<Renderer>().material = material0[Random.Range(0,23)];
					rend.material = materialSix[randNum];
					Debug.Log("we are in bWall");
				}
				
			}// else if
			
			else if((number == 6 && colObst != 0) || (choCol == 14 && colObst == 0)){
				bWall = GameObject.FindGameObjectsWithTag("discoBot");
				
				for(int i = 0; i < 14; i++){//places QB move position material
					randNum = Random.Range(0,23);
					rend = bWall[i].GetComponent<Renderer>();
					//bWall[i].GetComponent<Renderer>().material = material0[Random.Range(0,23)];
					rend.material = materialSeven[randNum];
					Debug.Log("we are in bWall");
				}
				
			}// else if
			
			else if((number == 7 && colObst != 0) || (choCol == 15 && colObst == 0)){
				bWall = GameObject.FindGameObjectsWithTag("discoBot");
				
				for(int i = 0; i < 14; i++){//places QB move position material
					randNum = Random.Range(0,23);
					rend = bWall[i].GetComponent<Renderer>();
					//bWall[i].GetComponent<Renderer>().material = material0[Random.Range(0,23)];
					rend.material = materialEight[randNum];
					Debug.Log("we are in bWall");
				}
				
			}// else if
			
			
		}
		
		
		else if(colObst == 0 && state && Time.time > next)//if colobst !=0 spawn a normal obstacle
		{
			
			next = Time.time + rate;
			currObstacle = obstacles[number];
			obstacle = Instantiate(currObstacle, spawn.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
			obstFreeze = obstacle.GetComponent<Rigidbody>();
			
			obstFreeze.freezeRotation = true;
			
			obstacle.GetComponent<Rigidbody>().AddForce(spawn.forward * 500);
			
			
			/*if((wall == 0 && number == 0) || (wall == 0 && choCol == 8)){
				
				
				for(int i = 0; i < 14; i++){//places QB move position material
					rend = bWall[i].GetComponent<Renderer>();
					rend.sharedMaterial = material0[Random.Range(0,23)];
				}
				
			}//if
			
			else if(wall == 0 && number == 1 || (wall == 0 && choCol == 9)){
				
				
				for(int i = 0; i < 14; i++){//places QB move position material
					rend = bWall[i].GetComponent<Renderer>();
					rend.sharedMaterial = material1[Random.Range(0,23)];
				}
				
			}// else if
			
			else if(wall == 0 && number == 2 || (wall == 0 && choCol == 10)){
				
				
				for(int i = 0; i < 14; i++){//places QB move position material
					rend = bWall[i].GetComponent<Renderer>();
					rend.sharedMaterial = material2[Random.Range(0,23)];
				}
				
			}// else if
			
			else if(wall == 0 && number == 3 || (wall == 0 && choCol == 11)){
				
				
				for(int i = 0; i < 14; i++){//places QB move position material
					rend = bWall[i].GetComponent<Renderer>();
					rend.sharedMaterial = material3[Random.Range(0,23)];
				}
				
			}// else if
			
			else if(wall == 0 && number == 4 || (wall == 0 && choCol == 12)){
				
				
				for(int i = 0; i < 14; i++){//places QB move position material
					rend = bWall[i].GetComponent<Renderer>();
					rend.sharedMaterial = material4[Random.Range(0,23)];
				}
				
			}// else if
			
			else if(wall == 0 && number == 5 || (wall == 0 && choCol == 13)){
				
				
				for(int i = 0; i < 14; i++){//places QB move position material
					rend = bWall[i].GetComponent<Renderer>();
					rend.sharedMaterial = material5[Random.Range(0,23)];
				}
				
			}// else if
			
			else if(wall == 0 && number == 6 || (wall == 0 && choCol == 14)){
				
				
				for(int i = 0; i < 14; i++){//places QB move position material
					rend = bWall[i].GetComponent<Renderer>();
					rend.sharedMaterial = material6[Random.Range(0,23)];
				}
				
			}// else if
			
			else if(wall == 0 && number == 7 || (wall == 0 && choCol == 15)){
				
				
				for(int i = 0; i < 14; i++){//places QB move position material
					rend = bWall[i].GetComponent<Renderer>();
					rend.sharedMaterial = material7[Random.Range(0,23)];
				}
				
			}// else if*/
			
		}
		
		
		
		
		
	}
	
	
	
}
