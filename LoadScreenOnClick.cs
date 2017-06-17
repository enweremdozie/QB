using UnityEngine;
using System.Collections;

public class LoadScreenOnClick : MonoBehaviour {
		public GameObject loadingImage;
	public GameObject NewGame; 

		public void LoadScene(int level){
		    NewGame.SetActive (false);
			loadingImage.SetActive (true);
			Application.LoadLevel (level);
		}
	}
