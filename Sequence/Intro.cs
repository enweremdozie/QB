using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {

	string text1 = "Ama is from Chalgs and like the people of Chalgs Ama has 2 qualities";

	void OnGUI(){
		GUI.TextField (new Rect (150, 270, 200, 20), text1, 70, GUIStyle.none);
	}
}
