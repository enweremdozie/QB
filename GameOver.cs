using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	/*private Animator callAnim;
	private GameObject callAll;
	bool state = false;


	


	// Use this for initialization
	void Start () {
		callAll = GameObject.FindGameObjectWithTag("QB");
		callAnim = callAll.GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}*/


	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "obst"){
		Destroy(col.gameObject);
			//state = true;
			//callAnim.SetBool("Death",state);
		Debug.Log("its working");
		//state = false;
		}
	}
}
