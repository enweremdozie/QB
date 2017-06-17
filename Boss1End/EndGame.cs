using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

	int end = 0;

	public void End(){
		end++;
		Debug.Log ("This is it " + end);
	}
}
