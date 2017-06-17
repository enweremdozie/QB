using UnityEngine;
using System.Collections;

public class Ama3 : MonoBehaviour {

	string text1 = "You have met Ama";

	void OnGUI(){
		GUI.TextField (new Rect (265, 270, 200, 20), text1, 70, GUIStyle.none);
	}

}
