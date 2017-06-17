using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour {

	public Transform target;
	float currentAngle;
	private Touch initialTouch = new Touch();
	float distance;
	bool start = true;
	float duration = 0.1f;
	private bool hasSwiped = true;
	float speed = 10f;
	int prevSwipe;
	int direction;
	int camPosition;
    public bool origin;
	public int Layer = 0;
	float LayerDist = 38f;
	int PrevLayer = 0;
	bool across;
	bool along;
	public bool left;
	public bool right;
	public bool back;
	public bool front;
	public AudioSource source;
	public AudioSource SecondSource;
	//public AudioClip[] Layers = new AudioClip[12];


	void Start(){
		camPosition = 4;
		across = false;
		along = false;
		origin = true;
		left = false;
		right = false;
		back = false;
		front = false;
		source = GetComponent<AudioSource>();
	}
	void Update () {
		if (Layer == 1) {
			speed = 1250f;
		} 
		else if (Layer == 2) {
			speed = 1100f;
		} 
		else if (Layer == 3) {
			speed = 1000f;
		} 
		else if (Layer == 4) {
			speed = 900f;
		} 
		else if (Layer == 5) {
			speed = 800f;
		} 
		else if (Layer == 6) {
			speed = 700f;
		} 
		else if (Layer == 7) {
			speed = 600f;
		} 
		else if (Layer == 8) {
			speed = 500f;
		} 
		else if (Layer == 9) {
			speed = 400f;
		} 
		else if (Layer == 10) {
			speed = 300f;
		} 
		else if (Layer == 12) {
			speed = 250f;
		} 
		else if (Layer > 13) {
			speed = 200f;
		}

		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began) {
				initialTouch = touch;

			} 
			else if (touch.phase == TouchPhase.Moved && hasSwiped) {
				float deltaX = initialTouch.position.x - touch.position.x; //change in x
				float deltaY = initialTouch.position.y - touch.position.y; //change in y
				distance = Mathf.Sqrt ((deltaX * deltaX) + (deltaY * deltaY)); //pythagoras for distance
				bool swipedSideways = Mathf.Abs (deltaX) > Mathf.Abs (deltaY); //whether swipe was wade sideways

				if (Input.touchCount == 1 && distance > 100f) {
					/******************************************************SWIPE LEFT*******************************************************/

					if ((swipedSideways && deltaX > 0)) {//swipe left
						if (along == true) {
							across = true;
						}
						 if (origin == false) {//MOVING SPHERE ON LEFT SWIPE

							GameObject.FindGameObjectWithTag("QB").transform.RotateAround (Vector3.zero, Vector3.up, -speed * Time.deltaTime);
						}
					
					}//swipe left

					/******************************************************SWIPE RIGHT*******************************************************/
					else if ((swipedSideways && deltaX <= 0)) {//swipe right
						Debug.Log ("swiped Right");
						if (along == true) {
							across = true;
						}
						 if (origin == false) {//MOVING SPHERE ON RIGHT SWIPE
							GameObject.FindGameObjectWithTag("QB").transform.RotateAround (Vector3.zero, Vector3.up, speed * Time.deltaTime);
						}

					} 

					/******************************************************SWIPE UP*******************************************************/

					else if (!swipedSideways && deltaY <= 0) {//swipe up

						if (across == true) {
							across = false;
						}
						if (origin == true) {//ORIGIN
							GameObject.FindGameObjectWithTag("QB").transform.Translate (1f, 0, 0);
							prevSwipe = 3;
							origin = false;
							Layer++;
							along = true;
						} 
						else if (origin == false && Layer <= 11) {
							Layer++;
							GameObject.FindGameObjectWithTag("QB").transform.Translate (0.65f, 0, 0);
						} 
						else if (origin == false && Layer == 12) {
							GameObject.FindGameObjectWithTag("QB").transform.Translate (0.3f, 0, 0);
							Layer = 13;
						}

						/*if (Layer == 2) {
							source.clip = Layers [0];
							source.Play();
						}
						else if (Layer == 3) {
							source.clip = Layers [1];
							source.Play();
						} 
						else if (Layer == 4) {
							source.clip = Layers [2];
							source.Play();
						}
						else if (Layer == 5) {
							source.clip = Layers [3];
							source.Play();
						}
						else if (Layer == 6) {
							source.clip = Layers [4];
							source.Play();
						}
						else if (Layer == 7) {
							source.clip = Layers [5];
							source.Play();
						}
						else if (Layer == 8) {
							source.clip = Layers [6];
							source.Play();
						}
						else if (Layer == 9) {
							source.clip = Layers [7];
							source.Play();
						}
						else if (Layer == 10) {
							source.clip = Layers [8];
							source.Play();
						}
						else if (Layer == 11) {
							source.clip = Layers [9];
							source.Play();
						}
						else if (Layer == 12) {
							source.clip = Layers [10];
							source.Play();
						}
						else if (Layer == 13) {
							source.clip = Layers [11];
							source.Play();
						}*/

					}

					/******************************************************SWIPE DOWN*******************************************************/
					else if (!swipedSideways && deltaY > 0) {//swipe down
						if (origin == false && Layer <= 12) {
							Layer--;
							GameObject.FindGameObjectWithTag("QB").transform.Translate (-0.65f, 0, 0);
						} 
						else if (origin == false && Layer == 13) {
							GameObject.FindGameObjectWithTag("QB").transform.Translate (-0.3f, 0, 0);
							Layer = 12;
						}
						/*if (Layer == 1 || Layer == 12) {
							source.clip = Layers [0];
							source.Play();
						}
						else if (Layer == 2 || Layer == 11) {
							source.clip = Layers [1];
							source.Play();
						} 
						else if (Layer == 3 || Layer == 10) {
							source.clip = Layers [2];
							source.Play();
						}
						else if (Layer == 4 || Layer == 9) {
							source.clip = Layers [3];
							source.Play();
						}
						else if (Layer == 5 || Layer == 8) {
							source.clip = Layers [4];
							source.Play();
						}
						else if (Layer == 6 || Layer == 7) {
							source.clip = Layers [5];
							source.Play();
						}*/
					}
					hasSwiped = false;
					Debug.Log ("Layer is " + Layer);
				}
		}
			else if (touch.phase == TouchPhase.Ended) {
				initialTouch = new Touch ();
				hasSwiped = true;
			}
		}
	}

}
