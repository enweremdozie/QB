using UnityEngine;
using System.Collections;

public class KingColor : MonoBehaviour {


	string text1 = "The ruler is the only one who can have more than one color at any given time as long as the colors are \nseperated ";

	void OnGUI(){

		GUI.TextField (new Rect (10, 270, 200, 20), text1, 130, GUIStyle.none);

	}
}
