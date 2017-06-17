using UnityEngine;
using System.Collections;

public class NightMare : MonoBehaviour
{
	public Material black;
	public Material otherMat;
	public GameObject[] levelLeft = new GameObject[40];
	public GameObject[] levelRight = new GameObject[40];
	public GameObject[] levelTop = new GameObject[40];
	public GameObject[] levelBottom = new GameObject[40];
	public GameObject[] back = new GameObject[2];
	public Material[] leftMAt = new Material[8];
	public Material[] rightMat = new Material[8];
	public Material blue;
	public Material red;
	public Material green;
	public Material yellow;
	public Material sky;
    GameObject topR;
	GameObject topL;
	GameObject botR;
	GameObject botL;
	float duration = 0.5f;
	public bool QBdark = true;
	int num;
	bool cond = true;
	GameObject[] other;
	//GameObject[] other;
	GameObject[] leftSide;
	GameObject[] rightSide;
	bool firstState = true;
	int firstIndex = 0;
	int secondIndex = 0;
	bool state = true;

	// Use this for initialization
	void Awake(){
		other = GameObject.FindGameObjectsWithTag("LevelWall");
		leftSide = GameObject.FindGameObjectsWithTag("WallLeft");
		rightSide = GameObject.FindGameObjectsWithTag("WallRight");
		topR = GameObject.FindGameObjectWithTag ("TR");
		botR = GameObject.FindGameObjectWithTag ("BR");
		topL = GameObject.FindGameObjectWithTag ("TL");
		botL = GameObject.FindGameObjectWithTag ("BL");
	}


	public void Lights(int j){
		//RenderSettings.skybox = sky;
		QBdark = GameObject.Find("manager").GetComponent<GameManager>().QBdark;//for deciding if QB is dark
		//GameObject.Find("manager").GetComponent<QB_color>().QBtrans();
		/*if (QBdark) {


		}*/
		back[0].GetComponent<Renderer>().sharedMaterial = otherMat;
		back[1].GetComponent<Renderer>().sharedMaterial = otherMat;
		//if (state) {
			for (int i = 0; i < levelLeft.Length; i++) {
			
				levelLeft [i].GetComponent<Renderer> ().sharedMaterial = otherMat;

				levelRight [i].GetComponent<Renderer> ().sharedMaterial = otherMat;
				levelTop [i].GetComponent<Renderer> ().sharedMaterial = otherMat;
				levelBottom [i].GetComponent<Renderer> ().sharedMaterial = otherMat;

				topR.GetComponent<Renderer> ().sharedMaterial = black;
				topL.GetComponent<Renderer> ().sharedMaterial = black;
				botR.GetComponent<Renderer> ().sharedMaterial = black;
				botL.GetComponent<Renderer> ().sharedMaterial = black;

				//if (i == (levelLeft.Length - 1)) {
			//		state = false;
				//}
			
			//}
		}
		//QBdark = GameObject.Find("manager").GetComponent<GameManager>().QBdark; 
	
	}


}






