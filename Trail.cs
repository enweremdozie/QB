using UnityEngine;
using System.Collections;

public class Trail : MonoBehaviour {

	public Material head;
	public Material tail;
	public GameObject[] levelLeft = new GameObject[40];
	public GameObject[] levelRight = new GameObject[40];
	public GameObject[] levelTop = new GameObject[40];
	public GameObject[] levelBottom = new GameObject[40];
	public GameObject[] back = new GameObject[2];
	public Material sky1;
	public Material sky2;
	public int startPos = 39;
	public int prev = 0;
	public int next = 0;
	float duration = 0.09f;
	float colorWait = 0.8f;
	bool state = true;
	bool color = false;
	public int trans = 0;
	public Material[] mat = new Material[24]; 
	int ran1 = 0;
	int ran2 = 0;
	int ran3 = 0;
	int ran4 = 0;
	int colorCount = 0;
	public int choose = 1;
	public AudioSource qb;
	bool bossBat = true;
	//public GameObject obstacle;
	int count = 0;

	
	
	// Use this for initialization
	void Start () {
		//qb.Play ();

		//StartCoroutine("wait");
		//rail(38,39);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	public void begin(){
		choose = Random.Range (1, 4);

		rails(38,39);
	}

	public void rails(int nextShell, int prevShell){
		
		//Debug.Log ("count: " + count);
		back [0].GetComponent<Renderer> ().sharedMaterial = tail;
		back [1].GetComponent<Renderer> ().sharedMaterial = tail;
			//RenderSettings.skybox = sky1;

		if (count == 11 && nextShell < 39) {
			levelLeft [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
			levelTop [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
			levelBottom [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
			levelRight [nextShell].GetComponent<Renderer> ().sharedMaterial = head;

			levelLeft [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
			levelTop [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
			levelBottom [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
			levelRight [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;

			nextShell--;
			prevShell--;
			next = nextShell;
			prev = prevShell;
			if (nextShell == 0) {
				state = false;
				color = true;
				StartCoroutine ("ColorPause");
			} 
			else {
				state = false;
				StartCoroutine ("Wait");
			}
		}



		
		
		else if (state && !color && count < 11) {

			//obstacle.transform.Translate (new Vector3 (-1.694f, 0, 0));

				if (nextShell < 39) {
			//Debug.Log("works");
					if (choose == 1) {
						levelLeft [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
						levelTop [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
						//levelBottom [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
					    levelRight [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
					
						levelLeft [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
						levelTop [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
						//levelBottom [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
					    levelRight [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
					} 
				else if (choose == 2) {
					    
						levelRight [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
						levelTop [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
						levelBottom [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
					
						levelRight [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
						levelBottom [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
						levelTop [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
					} 
				else if (choose == 3) {
						levelLeft [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
						levelRight [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
						levelBottom [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
					
						levelLeft [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
						levelRight [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
						levelBottom [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
					} 
				else if (choose == 4) {
						levelLeft [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
						levelTop [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
						//levelRight [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
					    levelBottom [nextShell].GetComponent<Renderer> ().sharedMaterial = head;
					
						levelLeft [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
						levelTop [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
						//levelRight [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
					    levelBottom [prevShell].GetComponent<Renderer> ().sharedMaterial = tail;
					}
				}
				nextShell--;
				prevShell--;
				next = nextShell;
				prev = prevShell;
				if (nextShell == 0) {
					state = false;
					color = true;
					StartCoroutine ("ColorPause");
				} 
			else {
					state = false;
					StartCoroutine ("Wait");
				}
			} 
	
	else if (!state && color && count < 11) {
				RenderSettings.skybox = sky2;
			
				for (int j = 0; j < 40; j++) {
				
					ran1 = Random.Range (0, 23);
					ran2 = Random.Range (0, 23);
					ran3 = Random.Range (0, 23);
					ran4 = Random.Range (0, 23);
					levelLeft [j].GetComponent<Renderer> ().sharedMaterial = mat [ran1];
					levelTop [j].GetComponent<Renderer> ().sharedMaterial = mat [ran2];
					levelBottom [j].GetComponent<Renderer> ().sharedMaterial = mat [ran3];
					levelRight [j].GetComponent<Renderer> ().sharedMaterial = mat [ran4];
				
				
				}
				StartCoroutine ("ColorPause");
			
			}

	}
	
	IEnumerator Wait() {
		
		yield return new WaitForSeconds(duration);
		state = true;
		
		rails(next, prev);
	}
	
	IEnumerator ColorPause() {
		
		yield return new WaitForSeconds(colorWait);
		state = false;
		color = true;
		colorCount++;
	//	GameObject.FindGameObjectWithTag ("wall1").GetComponent<BoxCollider>().isTrigger = true;
	//	Debug.Log ("collider now active");
		if(colorCount == 6){
			state = true;
			color = false;
			choose = Random.Range (1, 4);
			colorCount = 0;
			rails(38, 39);
		}
		rails(next, prev);
	}
}
