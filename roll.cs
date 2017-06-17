using UnityEngine;
using System.Collections;

public class roll : MonoBehaviour {

	private GameObject callAll;
	private Animator callAnim;
	bool state = true;


	// Use this for initialization
	void Start () {
		callAll = GameObject.FindGameObjectWithTag("obst");
		callAnim = callAll.GetComponent<Animator>();

	
	}
	
	// Update is called once per frame
	void Update () {

	



		
	}
}
