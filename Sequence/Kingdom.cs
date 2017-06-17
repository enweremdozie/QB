using UnityEngine;
using System.Collections;

public class Kingdom : MonoBehaviour {

	string text1 = "In Chalgs for balance in power and unity amongst differnt shapes there are three rules the gods and the primary \nfamilies go by\n1. EVERY FAMILY OF PRIMARY SHAPES GETS TO RULE FOR A TERM \n2. NO RULER IS THE SAME SHAPE AS THE NEXT \n3. EVERY RULER IS RESPONSIBLE FOR THE NEXT FROM BIRTH\nFor the last 100 years King Vash(a cube) has killed every ruler born after him, not one of which was a cube \ngoing by the second rule, until Ama.";

	void OnGUI(){
		
		GUI.TextField (new Rect (10, 50, 200, 20), text1, 460, GUIStyle.none);

	}

}
