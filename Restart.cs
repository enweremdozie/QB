using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	public float wait;
	public int scene;
	// Use this for initialization
	void Start () {
		StartCoroutine ("WaitSomSeconds");
	}


	IEnumerator WaitSomSeconds(){
		yield return new WaitForSeconds (wait);
		Application.LoadLevel (scene);//restart
	}
}
