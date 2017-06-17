using UnityEngine;
using System.Collections;

public class QB_color : MonoBehaviour {
	public Material blueDeath;
	public Material greenDeath;
	public Material redDeath;
	public Material yellowDeath;
	public Material blue;
	public Material green;
	public Material red;
	public Material yellow;
	public Material black;
	float duration = 2f;
	float lerp = 0f;
	int pick;
	int random;
	bool state = true;
	GameObject topR;
	GameObject topL;
	GameObject botR;
	GameObject botL;
	Renderer rendTL;
	Renderer rendTR;
	Renderer rendBL;
	Renderer rendBR;
	bool nightMare = false;
	bool nmover;

	void Awake(){
		topR = GameObject.FindGameObjectWithTag("TR");
		topL = GameObject.FindGameObjectWithTag("TL");
		botR = GameObject.FindGameObjectWithTag("BR");
		botL = GameObject.FindGameObjectWithTag("BL");

		rendTL = topL.GetComponent<Renderer> ();
		rendTR = topR.GetComponent<Renderer> ();
		rendBL = botL.GetComponent<Renderer> ();
		rendBR = botR.GetComponent<Renderer> ();

	
	}

	public void QBcolors(bool collide){
		nightMare = GameObject.Find("manager").GetComponent<Xob>().nightmare;
	//	nmover = GameObject.Find ("manager").GetComponent<Xob> ().NMover;

		if (nightMare == false && nmover == true) {
			rendTL.sharedMaterial = blue;
			rendTR.sharedMaterial = yellow;
			rendBL.sharedMaterial = red;
			rendBR.sharedMaterial = green;
		}

	}


	/*public void QBtrans(){
		//lerp = Mathf.PingPong (Time.time, duration) / duration;


		if (!nightMare) {
			rendTL.sharedMaterial = green;
			rendTR.sharedMaterial = red;
			rendBL.sharedMaterial = yellow;
			rendBR.sharedMaterial = blue;

		} 
		else if (nightMare) {
			rendTL.sharedMaterial = black;
			rendTR.sharedMaterial = black;
			rendBL.sharedMaterial = black;
			rendBR.sharedMaterial = black;

		}
}*/


	
}






