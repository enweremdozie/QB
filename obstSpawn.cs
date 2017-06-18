using UnityEngine;
using System.Collections;

public class obstSpawn : MonoBehaviour {
	
	//public Transform[] spawn = new Transform [8];
	public GameObject[] qbstacle = new GameObject[8];
	int random;
	Rigidbody obstFreeze;
	GameObject spawnLoc;
	float next = 0;
	float rate = 3;
	public float Spawntime = 1f;
	int firstpos;
	int secpos;
	
	// Use this for initialization
	void Start () {
		//random =  Random.Range(1,2);
		//InvokeRepeating("createObst", Spawntime, 3f);
		random = Random.Range(0,100);
		StartCoroutine("waitSomeTime");
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	
	
	void createObst(int rand) {
		GameObject obstacle;

		print (random + " was selected");
		
		if(secpos == 2){
			random = 49;
			}

		if(firstpos == 2){
			random = 51;

		}
		
		if(random < 50 || secpos == 2){
			spawnLoc = GameObject.FindGameObjectWithTag ("pos4");
			obstacle = Instantiate(qbstacle[0], spawnLoc.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
			
			obstFreeze = obstacle.GetComponent<Rigidbody>();
			obstFreeze.freezeRotation = true;
			//StartCoroutine("waitSomeTime");
			//print ("1 was selected");
			//random =  Random.Range(1,2);
			print ("0 was selected");
			StartCoroutine("waitSomeTime");
			firstpos++;

			if(secpos == 2)
				secpos = 0;
		}
		
		else if(random >= 50 || firstpos == 2){
			spawnLoc = GameObject.FindGameObjectWithTag ("pos4");
			obstacle = Instantiate(qbstacle[1], spawnLoc.transform.localPosition, Quaternion.Euler(0, 180, 0)) as GameObject;
			
			obstFreeze = obstacle.GetComponent<Rigidbody>();
			obstFreeze.freezeRotation = true;
			
			print ("1 was selected instead");
			
			StartCoroutine("waitSomeTime");

			secpos++;

			if(firstpos == 2)
				firstpos = 0;
		}
	}
	
	
	IEnumerator waitSomeTime() {
		
		yield return new WaitForSeconds(3);
		//cond = true;
		//print ("we just waited 0.5 seconds");
		random = Random.Range(0,100);
		createObst(random);
	}
	
}





