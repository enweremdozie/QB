using UnityEngine;
using System.Collections;

public class Colors : MonoBehaviour {

	string text1 = "Every color has a good side, a dark side and a meaning, for instance if a shape is dark Red that shape is \nangry and if a shape is Pink then that shape is in love, which means there is complete transparency in Chalgs \nbecause your expression is your color";

	void OnGUI(){
		GUI.TextField (new Rect (20, 250, 200, 20), text1, 260, GUIStyle.none);
	}

}
