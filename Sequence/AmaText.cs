using UnityEngine;
using System.Collections;

public class AmaText : MonoBehaviour {

	string text1 = "Meet Ama";

	void OnGUI(){
			GUI.TextField (new Rect (300, 270, 200, 20), text1, 25, GUIStyle.none);
	}
}
