using UnityEngine;
using System.Collections;

public class Ama2 : MonoBehaviour {

	string text1 = "The gods broke all three rules for Ama and King Vash didn't suspect a thing";

	void OnGUI(){

		GUI.TextField (new Rect (120, 270, 200, 20), text1, 80, GUIStyle.none);

	}
}
