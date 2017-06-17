using UnityEngine;
//using System.Collections;

public class Chalgs : MonoBehaviour {

	string text1 = "She has a shape 'ANYI' which means cube and a color based on how she feels at a given moment";

	void OnGUI(){
		GUI.TextField (new Rect (50, 270, 200, 20), text1, 95, GUIStyle.none);
	}

}