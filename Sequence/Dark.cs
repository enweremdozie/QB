using UnityEngine;
using System.Collections;

public class Dark : MonoBehaviour {

	string text1 = "The evil side of a shape sets in with darkness, darkness comes as a result of the bad things a shape does";

	void OnGUI(){
		GUI.TextField (new Rect (10, 270, 200, 20), text1, 140, GUIStyle.none);
	}

}
