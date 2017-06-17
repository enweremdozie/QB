using UnityEngine;
using System.Collections;

public class Black : MonoBehaviour {
	string text1 = "until darkness takes over completely";

	void OnGUI(){
		GUI.TextField (new Rect (230, 270, 200, 20), text1, 70, GUIStyle.none);
	}

}
