using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour {
	private Touch initialTouch;
	float distance;
	bool hasSwiped = true;
	Camera cam;
	int origin = 0;
	public GameObject[] camPositions = new GameObject[4];
	int camLocation = 4;
	public Transform lookAt;

	private bool smooth = true;
	private float smoothSpeed = 1f;
	Vector3 position;
	Quaternion CamRotation;
	Quaternion rotation;
	bool swipe = false;
	int PrevCamPos = 4;
	/*public Camera LCam;
	public Camera RCam;
	public Camera FCam;
	public Camera BCam;*/



	/*Vector3 left = new Vector3 (0,2.3f,3.5f);
	Vector3 right = new Vector3 (0,2.3f,-3.5f);
	Vector3 up = new Vector3 (3.5f,2.3f,0);
	Vector3 down = new Vector3 (-3.5f,2.3f,0);*/


	// Use this for initialization
	void Start () {
		/*camPositions[0].transform.position = new Vector3(0,2.3f,3.5f);
		camPositions[1].transform.position = new Vector3(0,2.3f,-3.5f);
		camPositions[2].transform.position = new Vector3(3.5f,2.3f,0);
		camPositions[3].transform.position = new Vector3 (-3.5f,2.3f,0);*/
		//camPositions [0] = new Vector3 ();
		//transform.eulerAngles = new Vector3 (0, 0, 60);
	}
	void Update(){
		if(PrevCamPos != camLocation){
			transform.LookAt (lookAt);
			//swipe = false;
		}
	}
	// Update is called once per frame
	private void LateUpdate () {
		//left = lookAt + 
		//Debug.Log("cam Location " + camLocation);


		/*Vector3 targetPostition = new Vector3( this.transform.position.x, 
			this.transform.position.y, 
			this.transform.position.z ) ;
		this.transform.LookAt( targetPostition ) ;*/


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
					if ((swipedSideways && deltaX > 0)) {//swipe left
						//Debug.Log ("Swiped left");
						if (camLocation == 1) {
							position = camPositions [3].transform.position;
						//	CamRotation = lookAt.rotation;
							if (smooth) {
								
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								PrevCamPos = 1;
								camLocation = 4;

							} 
							else {
								//transform.position = position;
								PrevCamPos = 1;
								camLocation = 4;
							}
						} 


						else if (camLocation == 2) {
							position = camPositions [2].transform.position;
							//CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 2;
								camLocation = 3;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 2;
								camLocation = 3;
							}
						} 


						else if (camLocation == 3) {
							position = camPositions [0].transform.position;
							//CamRotation = lookAt.rotation;
		
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 3;
								camLocation = 1;
							
							
							} 
							else {
							//	transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 3;
								camLocation = 1;
							}
						} 


						else if (camLocation == 4) {
							position = camPositions [1].transform.position;
						//	CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 4;
								camLocation = 2;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 4;
								camLocation = 2;
							}
						}

					} 


					else if ((swipedSideways && deltaX <= 0)) {//swipe right
						//Debug.Log("swiped right");
						if (camLocation == 1) {
							position = camPositions [2].transform.position;
						//	CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 1;
								camLocation = 3;
							} 
							else {
								//transform.position = position;
							//	transform.rotation = CamRotation;
								PrevCamPos = 1;
								camLocation = 3;
							}
						} 


						else if (camLocation == 2) {
							position = camPositions [3].transform.position;
							//CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 2;
								camLocation = 4;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 2;
								camLocation = 4;
							}
						} 


						else if (camLocation == 3) {
							position = camPositions [1].transform.position;
							//CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 3;
								camLocation = 2;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 3;
								camLocation = 2;
							}
						} 
						else if (camLocation == 4) {
							position = camPositions [0].transform.position;
						//	CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 4;
								camLocation = 1;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 4;
								camLocation = 1;
							}
						}
					} 


					else if (!swipedSideways && deltaY <= 0) {//swipe up
						//Debug.Log("swiped up");
						if (camLocation == 1) {
							position = camPositions [0].transform.position;
							//CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 1;
								camLocation = 1;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 1;
								camLocation = 1;
							}
						} 


						else if (camLocation == 2) {
							position = camPositions [1].transform.position;
							//CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 2;
								camLocation = 2;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 2;
								camLocation = 2;
							}
						} 


						else if (camLocation == 3) {
							position = camPositions [2].transform.position;
							//CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 3;
								camLocation = 3;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 3;
								camLocation = 3;
							}
						} 


						else if (camLocation == 4) {
							position = camPositions [3].transform.position;
						//	CamRotation = lookAt.rotation;

							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 4;
								camLocation = 4;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 4;
								camLocation = 4;
							}
						}
					}


					else if (!swipedSideways && deltaY > 0){//swipe down
						//Debug.Log("swiped down");
						if (camLocation == 1) {
							position = camPositions [1].transform.position;
						//	CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 1;
								camLocation = 2;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 1;
								camLocation = 2;
							}
						} 


						else if (camLocation == 2) {
							position = camPositions [0].transform.position;
							//CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 2;
								camLocation = 1;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 2;
								camLocation = 1;
							}
						} 


						else if (camLocation == 3) {
							position = camPositions [3].transform.position;
							//CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 3;
								camLocation = 4;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 3;
								camLocation = 4;
							}
						} 


						else if (camLocation == 4) {
							position = camPositions [2].transform.position;
						//	CamRotation = lookAt.rotation;
							if (smooth) {
								transform.position = Vector3.Lerp(transform.position,position,smoothSpeed);
								//transform.rotation = CamRotation;
								PrevCamPos = 4;
								camLocation = 3;
							} 
							else {
								//transform.position = position;
								//transform.rotation = CamRotation;
								PrevCamPos = 4;
								camLocation = 3;
							}
						}
					}
					hasSwiped = false;
				}
			}
			else if (touch.phase == TouchPhase.Ended) {
				initialTouch = new Touch ();
				hasSwiped = true;
			}
		}
	
	}

}
