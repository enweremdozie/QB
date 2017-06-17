using UnityEngine;
using System.Collections;

public class QB : MonoBehaviour {

	string text1 = "Now meet QB(as in cube, you get it right)";

	void OnGUI(){
		GUI.TextField (new Rect (200, 270, 200, 20), text1, 70, GUIStyle.none);
	}
}