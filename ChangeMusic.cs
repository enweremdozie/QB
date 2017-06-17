using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {
	public AudioClip mainMenu;
	public AudioClip death;
	public AudioClip restart;
	public AudioClip lue;
	private AudioSource source;
	public bool PauseMusic;
	bool begin = true;


	void Awake () {
		source = GetComponent<AudioSource>();
	}

	void Update(){
		

	}
	
	void OnLevelWasLoaded(int level){
		/*if (Input.touchCount == 2) {
			Debug.Log ("count is 2");
		}*/
		if (level == 8) {
			source.clip = lue;
			source.Play ();
		}
		if (level == 9) {//Boss1
			//PauseMusic = GameObject.Find ("QB").GetComponent<QBAnimation> ().PauseMusic;
			//Debug.Log (PauseMusic);
			//if (PauseMusic == false && begin == true) {
				source.clip = mainMenu;
				source.Play ();
				//begin = false;
			//} 
		/*	else if (PauseMusic == true && begin == false) {
				source.Pause ();
			} 
			else if (PauseMusic == false && begin == false) {
				source.UnPause ();
			}*/
			//StartCoroutine ("wait");
		} 
		else if (level == 12) {//ebuc death
			source.clip = death;
			source.Play ();

		}
		else if (level == 13) {//ebuc restart
			source.clip = restart;
			source.Play ();

		}
	}

	/*IEnumerator wait(){
		source.Pause ();
		yield return new WaitForSeconds (3);
		source.UnPause ();

	}*/
}
