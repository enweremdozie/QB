using UnityEngine;
using System.Collections;

public class obstColor : MonoBehaviour {
	public Material obstBlue;
	public Material obstGreen;
	public Material obstRed;
	public Material obstYellow;

	int number;
	Material[] materials = new Material[4];
	bool state = true;
	
	
	// Use this for initialization
	void Start () {
		if(state){
			colors();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	
	void colors(){
		
		materials[0] = obstBlue;
		materials[1] = obstGreen;
		materials[2] = obstRed;
		materials[3] = obstYellow;
		
		
		
		while(state){
			number = Random.Range(0,3);
			//Debug.Log(number);
			
			//StartCoroutine(waitSomeTime(duration));
			Renderer rend = GetComponent<Renderer>();
			rend.sharedMaterial = materials[number];
			state = false;

			
		}
		
		
		
		
		
	}

	void changeState(){

		state = false;
		colors ();


	}
	
	

	
}






