using UnityEngine;
using System.Collections;

public class GameManager2 : MonoBehaviour
{
	//public static GameManager instance { get; set; }//properties

	bool xob;
	Xob xobState;
	int wallTex;
	float duration = 0.8f;
	int index = 0;
	float nextLevel = 5f;
	int nightTime = 0;
	int trackPhaThree = 0;
	bool bossBat = false;
	int qbCount = 0;
	public bool QBdark = false;
	bool collide = false;


	bool next = true;

	void Awake()
	{
		// instance = this;

	}
	// Use this for initialization
	void Start()
	{
		//GameObject.Find ("QB").GetComponent<QBAnimationNew> ().bossBat = 4;
		//xob = GameObject.Find("manager").GetComponent<Xob>().nightmare;
		//GameObject.Find ("manager").GetComponent<QB_color> ().QBcolors();
		GameObject.Find("manager").GetComponent<Xob2>().SpawnPhase2();
		GameObject.Find("manager").GetComponent<DiscoEnd> ().Lights();
		//StartCoroutine("waitSomeTime");
		//phaseTwo(xob);
		//phaseTwo(xob);
	}//start

	public void col(bool collide){
		if (collide) {


			//GameObject.Find ("manager").GetComponent<DiscoCity> ().choose(collide);
			GameObject.Find ("manager").GetComponent<Xob2> ().collide = collide;
			//GameObject.Find ("manager").GetComponent<Xob> ().collide = collide;
			GameObject.FindGameObjectWithTag ("minions").GetComponent<objectDestroyer> ().collide = collide;
		}

	}

	public void QBCol(bool collide){
		if (collide) {
			//GameObject.Find ("manager").GetComponent<DiscoCity> ().choose(collide);
			//GameObject.Find ("manager").GetComponent<Xob> ().qbcol = collide;
			//GameObject.FindGameObjectWithTag ("minions").GetComponent<objectDestroyer> ().collide = collide;
			//GameObject.Find ("manager").GetComponent<Xob> ().qbCount = qbCount++;
			//Debug.Log ("count for qb: " + qbCount);
			Application.LoadLevel (12);//ebuc death
		}
			
		// Update is called once per frame
		/*void Update()
	{
		//collide = GameObject.Find ("manager").GetComponent<score> ().collide;
		//GameObject.Find ("manager").GetComponent<QB_color> ().QBcolors (collide);     
	}

	public void phaseTwo(bool nightmare)
	{
		//collide = GameObject.Find ("manager").GetComponent<score> ().collide;
		//nightmare = GameObject.Find ("manager").GetComponent<Xob> ().nightmare;
		if (!nightmare) {
			QBdark = false;
			//collide = GameObject.Find ("manager").GetComponent<score> ().collide;
			GameObject.Find ("manager").GetComponent<DiscoEnd> ().qbcol();
			//GameObject.Find ("manager").GetComponent<Trail> ();
			//GameObject.Find ("manager").GetComponent<NightMare> ().Lights (index);
			next = GameObject.Find("manager").GetComponent<Xob2>().next;


		}
		/*else if (secpart == 15) {
			delay = true;
		
		}*/
		/*else if (nightmare) {//nightmare
			QBdark = true;
			//GameObject.Find ("manager").GetComponent<NightMare> ().Lights (index);
			trackPhaThree = GameObject.Find("manager").GetComponent<Xob2>().trackPhaThree;
			index++;

			//if (trackPhaThree == 7) {
			//	secpart = 0;
			//}

			if (index == 8) {
				index = 0;
			}
		}

		//	print("it works and is " + secpart);
		StartCoroutine("waitSomeTime");
	}

	
	IEnumerator waitSomeTime(){
		//xob = GameObject.Find ("manager").GetComponent<Xob2> ().nightmare;
		yield return new WaitForSeconds (duration);

		phaseTwo(xob);
	}*/

		/*IEnumerator waitForNextLevel()
	{
		
		yield return new WaitForSeconds (nextLevel);
		//xob = GameObject.Find("manager").GetComponent<Xob>().angry;
		delay = false;
		phaseTwo(startSecPart);

	}*/
	}
}

