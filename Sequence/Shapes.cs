using UnityEngine;
using System.Collections;

public class Shapes : MonoBehaviour {

	string text1 = "Generally there are four Primary shapes and colors that make up the others";

	void OnGUI(){
		GUI.TextField (new Rect (120, 270, 200, 20), text1, 80, GUIStyle.none);
	}

}
