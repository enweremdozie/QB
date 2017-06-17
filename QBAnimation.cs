using UnityEngine;
using System.Collections;

public class QBAnimation : MonoBehaviour {
	
	private GameObject callAll;
	private Animator callAnim;
	private GameObject levelObj;
	private Animator levelAnim;
	//private bool canSitR = false;
	//private bool canSitL = false;
	private Touch initialTouch = new Touch();
	private float distance = 0;
	private bool hasSwiped = true;
	int swipePosition = 10;
	//int randomStand = 3;
	//int flip = 3;
	bool standState = true;
	bool goingDown = true;
	bool goingUp = true;
	private bool across = true;
	private bool idle = false; 
	private Camera myCam;
	float mid;
	public bool level = true;
	int levelPos = 0;
	int bossBat;
	public AudioSource qb;
	public AudioSource Lever;
	public int PauseCount = 1;
	AudioSource source;
	public bool PauseMusic = false;
	public GameObject particle;

	//private float halfWay = 0;
	//public float standDuration = 3f;

	//private Touch doubleT = new Touch();

	
	
	// Use this for initialization
	void Start () {
		callAll = GameObject.FindGameObjectWithTag("QB"); //getting respective gameobject with tag
	    callAnim = callAll.GetComponent<Animator>();    //for calling respective animations
		levelObj = GameObject.FindGameObjectWithTag("level");//getting respective gameobject with tag
		levelAnim = levelObj.GetComponent<Animator>();//for calling respective animations
		myCam = Camera.main;
		mid = Screen.width / 2f;

		qb = GetComponent<AudioSource>();


	
		//sphere = GameObject.FindGameObjectWithTag("sphere");
	}
	
	// Update is called once per frame
	void Update () {
		
		bossBat = GameObject.Find ("manager").GetComponent<Xob> ().qbCount;

		//level = GameObject.Find("manager").GetComponent<Xob>().level;
		foreach (Touch t in Input.touches) {
			if (t.phase == TouchPhase.Began) {
				initialTouch = t;
			} 
			else if (t.phase == TouchPhase.Moved && hasSwiped) {
				float deltaX = initialTouch.position.x - t.position.x; //change in x
				float deltaY = initialTouch.position.y - t.position.y; //change in y
				distance = Mathf.Sqrt ((deltaX * deltaX) + (deltaY * deltaY)); //pythagoras for distance
				bool swipedSideways = Mathf.Abs (deltaX) > Mathf.Abs (deltaY); //whether swipe was wade sideways
				
				if (Input.touchCount == 2 && PauseCount % 2 != 0) {

					Time.timeScale = 0;
					PauseCount++;
					PauseMusic = true;
					//GameObject.Find ("QB").GetComponent<ChangeMusic> ().PauseMusic = true;
					//source.Pause ();
				} 
				else if (Input.touchCount == 2 && PauseCount % 2 == 0) {
					Time.timeScale = 1;
					PauseCount++;
					PauseMusic = false;
				//	GameObject.Find ("QB").GetComponent<ChangeMusic> ().PauseMusic = false;
				}
				
				
				else if (Input.touchCount == 1 && distance > 100f) { //if ONE finger is swiped at a distance 100 or greater 
					//Debug.Log ("when I swipe it writes");
					//Time.timeScale = 1;
					qb.Play ();

					//swipe left
					if (swipedSideways && deltaX > 0 && swipePosition == 6 && goingDown) { //swipe left at last position 
						particle.SetActive (false);
						callAnim.SetTrigger ("down6");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition = 6;
						goingDown = false;
						goingUp = true;
						idle = false;
						Debug.Log ("this is the initial touch position " + (initialTouch.position.x));
						Debug.Log ("this is the mid " + mid);
					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 5 && goingDown) {
						particle.SetActive (false);
						callAnim.SetTrigger ("down5");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition = 5;
						goingDown = false;
						goingUp = true;
						idle = false;

					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 4 && goingDown) {
						particle.SetActive (false);
						callAnim.SetTrigger ("down4");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition = 4;
						goingDown = false;
						goingUp = true;
						idle = false;
					} 
					else if (swipedSideways && deltaX > 0 && (swipePosition == 3 || swipePosition == 10) && goingDown && !idle) {
						particle.SetActive (false);
						callAnim.SetTrigger ("down3");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition = 2;// idle switches from 3 to 2 in animator
						goingDown = false;
						goingUp = true;
						idle = true;
						across = true;

					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 2 && goingDown) {
						particle.SetActive (false);
						callAnim.SetTrigger ("down2");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition = 2;
						goingDown = false;
						goingUp = true;
						idle = false;
					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 1 && goingDown) {
						particle.SetActive (false);
						callAnim.SetTrigger ("down1");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition = 1;
						goingDown = false;
						goingUp = true;
						idle = false;
					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 0 && goingDown) { //position 1 swipe left 
						particle.SetActive (false);
						callAnim.SetTrigger ("downSpec");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition = 0;
						goingDown = false;
						goingUp = true;
						idle = false;
					}
					else if (swipedSideways && deltaX > 0 && swipePosition == 3 && goingDown && idle) {
						particle.SetActive (false);
						callAnim.SetTrigger ("down0");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition = 3;
						goingDown = true;
						goingUp = true;
						idle = false;
						across = false;
					}

                    

					//swipe right

					else if (swipedSideways && deltaX <= 0 && swipePosition == 6 && goingUp) {
						particle.SetActive (false);
						callAnim.SetTrigger ("up7");
						myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
						swipePosition = 6;
						goingUp = false;
						goingDown = true;
						idle = false;

					}
					else if (swipedSideways && deltaX <= 0 && swipePosition == 5 && goingUp) {
						particle.SetActive (false);
						callAnim.SetTrigger ("up6");
						myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
						swipePosition = 5;
						goingUp = false;
						goingDown = true;
						idle = false;
					
					} 
					else if (swipedSideways && deltaX <= 0 && swipePosition == 4 && goingUp) {
						particle.SetActive (false);
						callAnim.SetTrigger ("up5");
						myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
						swipePosition = 4;
						goingUp = false;
						goingDown = true;
						idle = false;

					} 
					else if (swipedSideways && deltaX <= 0 && (swipePosition == 3 || swipePosition == 10) && goingUp) {
						particle.SetActive (false);
						callAnim.SetTrigger ("up4");
						myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
						swipePosition = 3;
						goingUp = false;
						goingDown = true;
						idle = true;
						across = true;

					} 
					else if (swipedSideways && deltaX <= 0 && swipePosition == 2 && goingUp) {
						particle.SetActive (false);
						callAnim.SetTrigger ("up3");
						myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
						swipePosition = 2;
						goingUp = false;
						goingDown = true;
						idle = false;

					} 
					else if (swipedSideways && deltaX <= 0 && swipePosition == 1 && goingUp) {
						particle.SetActive (false);
						callAnim.SetTrigger ("up2");
						myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
						swipePosition = 1;
						goingUp = false;
						goingDown = true;
						idle = false;

					} 
					else if (swipedSideways && deltaX <= 0 && swipePosition == 0 && goingUp) {
						particle.SetActive (false);
						callAnim.SetTrigger ("up1");
						myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
						swipePosition = 0;
						goingUp = false;
						goingDown = true;
						idle = false;

					}
				/*	else if(swipedSideways && deltaX <= 0 && swipePosition == 3 && goingUp && idle){

						callAnim.SetTrigger("up0");
						myCam.transform.Translate(new Vector3(0.15f, 0, 0));
						swipePosition = 3;
						goingUp = true;
						goingDown = true;
						idle = false;
						across = false;
					}*/
				

					/*else if(swipedSideways && deltaX > 0 && swipePosition == 10)//swipe left
					{
						
						//this.transform.Translate (new Vector3(0, -5f, 0));
						canSitL = true;
						callAnim.SetTrigger("spec2");
						//swipePosition--;
						swipePosition = 3;
					}*/

				

					else if (swipedSideways && deltaX > 0 && swipePosition == 1 && across) {
						//this.transform.Translate (new Vector3(0, -5f, 0));
						particle.SetActive (false);
						callAnim.SetTrigger ("SitToSitLeft");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition--;
						goingUp = true;
						goingDown = false;
						idle = false;

					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 2 && across) {
						//this.transform.Translate (new Vector3(0, -5f, 0));
						particle.SetActive (false);
						callAnim.SetTrigger ("SitToSitLeft2");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition--;
						goingUp = true;
						goingDown = false;
						idle = false;

					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 3 && across) {
						//this.transform.Translate (new Vector3(0, -5f, 0));
						particle.SetActive (false);
						callAnim.SetTrigger ("SitToSitLeft3");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition--;
						goingUp = true;
						goingDown = false;
						idle = false;

					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 4 && across) {
						//this.transform.Translate (new Vector3(0, -5f, 0));
						particle.SetActive (false);
						callAnim.SetTrigger ("SitToSitLeft4");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition--;
						goingUp = true;
						goingDown = false;
						idle = true;

					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 5 && across) {
						//this.transform.Translate (new Vector3(0, -5f, 0));
						particle.SetActive (false);
						callAnim.SetTrigger ("SitToSitLeft5");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition--;
						goingUp = true;
						goingDown = false;
						idle = false;
					
					} 
					else if (swipedSideways && deltaX > 0 && swipePosition == 6 && across) {
						//this.transform.Translate (new Vector3(0, -5f, 0));
						particle.SetActive (false);
						callAnim.SetTrigger ("SitToSitLeft6");
						myCam.transform.Translate (new Vector3 (-0.25f, 0, 0));
						//sphere.transform.Translate(new Vector3(-0.15f, 0, 0));
						swipePosition--;
						goingUp = true;
						goingDown = false;
						idle = false;

					} 
					else if (swipedSideways && deltaX <= 0) {//Swiped right
						
						
						if (swipedSideways && deltaX <= 0 && swipePosition == 0 && across) {
							//this.transform.Translate (new Vector3(0, 5f, 0));
							particle.SetActive (false);
							callAnim.SetTrigger ("SitToSitRight1");
							myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
							//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
							swipePosition++;
							goingUp = false;
							goingDown = true;
							idle = false;

						} 
						else if (swipedSideways && deltaX <= 0 && swipePosition == 1 && across) {
							//this.transform.Translate (new Vector3(0, 5f, 0));
							particle.SetActive (false);
							callAnim.SetTrigger ("SitToSitRight2");
							myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
							//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
							swipePosition++;
							goingUp = false;
							goingDown = true;
							idle = false;

						} 
						else if (swipedSideways && deltaX <= 0 && swipePosition == 2 && across) {
							//this.transform.Translate (new Vector3(0, 5f, 0));
							particle.SetActive (false);
							callAnim.SetTrigger ("SitToSitRight3");
							myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
							//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
							swipePosition++;
							goingUp = false;
							goingDown = true;
							idle = true;

						} 
						else if (swipedSideways && deltaX <= 0 && swipePosition == 3 && across) {
							//this.transform.Translate (new Vector3(0, 5f, 0));
							particle.SetActive (false);
							callAnim.SetTrigger ("SitToSitRight4");
							myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
							//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
							swipePosition++;
							goingUp = false;
							goingDown = true;
							idle = false;

						} 
						else if (swipedSideways && deltaX <= 0 && swipePosition == 4 && across) {
							//this.transform.Translate (new Vector3(0, 5f, 0));
							particle.SetActive (false);
							callAnim.SetTrigger ("SitToSitRight5");
							myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
							//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
							swipePosition++;
							goingUp = false;
							goingDown = true;
							idle = false;

						} 
						else if (swipedSideways && deltaX <= 0 && swipePosition == 5 && across) {
							//this.transform.Translate (new Vector3(0, 5f, 0));
							particle.SetActive (false);
							callAnim.SetTrigger ("SitToSitRight6");
							myCam.transform.Translate (new Vector3 (0.25f, 0, 0));
							//sphere.transform.Translate(new Vector3(0.15f, 0, 0));
							swipePosition = 6;
							goingUp = false;
							goingDown = true;
							idle = false;

						}
				
						
						
					} 
					else if ((!swipedSideways && deltaY > 0) && ((initialTouch.position.x) > mid) && level && bossBat == 4) {//swiped down on the right
						//this.transform.Rotate (new Vector3(0, 100f, 0));
						
						Debug.Log ("you swiped down on the right CW " + (initialTouch.position.x));

						if (levelPos == 0 || levelPos == 1) {
							Debug.Log (levelPos);
							if (levelPos == 0) {
								Debug.Log ("at least it enters");
								levelAnim.SetTrigger ("idle-4");
							} 
							else if (levelPos == 1) {
								levelAnim.SetTrigger ("1CW-2CW");
							}
							levelPos = 2;
						}

						else if (levelPos == 2) {
							levelAnim.SetTrigger ("2CW-3CW");
							levelPos = 3;
						}

						else if (levelPos == 3) {
							levelAnim.SetTrigger ("3CW-4CW");
							levelPos = 4;
						}

						else if (levelPos == 4) {
							levelAnim.SetTrigger ("4CW-1CW");
							levelPos = 1;
						}
					}

				
					else if ((!swipedSideways && deltaY > 0) && ((initialTouch.position.x) < mid) && level && bossBat == 4) {//swiped down on the left
					//this.transform.Rotate (new Vector3(0, 100f, 0));
						Debug.Log ("you swiped down on the left CCW" + (initialTouch.position.x));

						if (levelPos == 0 || levelPos == 1) {
							if (levelPos == 0) {
								levelAnim.SetTrigger ("idle-2");
							} 
							else if (levelPos == 1) {
								levelAnim.SetTrigger ("1CCW-4CCW");
							}
							levelPos = 4;
						}

						else if (levelPos == 2) {
							levelAnim.SetTrigger ("2CW-1CCW");
							levelPos = 1;
						}

						else if (levelPos == 3) {
							levelAnim.SetTrigger ("3CW-2CCW");
							levelPos = 2;
						}

						else if (levelPos == 4) {
							levelAnim.SetTrigger ("4CW-3CCW");
							levelPos = 3;
						}

							

				}

					//swiped up
					else if ((!swipedSideways && deltaY <= 0) && ((initialTouch.position.x) > mid) && level && bossBat == 4) {//swiped up on the right

						Debug.Log ("you swiped up on the right CCW" + (initialTouch.position.x));

			


						if (levelPos == 0 || levelPos == 1) {
							if (levelPos == 0) {
								levelAnim.SetTrigger ("idle-2");
							} 
							else if (levelPos == 1) {
								levelAnim.SetTrigger ("1CW-4CCW");
							}
							levelPos = 4;
						}

						else if (levelPos == 2) {
							levelAnim.SetTrigger ("2CW-1CCW");
							levelPos = 1;
						}

						else if (levelPos == 3) {
							levelAnim.SetTrigger ("3CW-2CCW");
							levelPos = 2;
						}

						else if (levelPos == 4) {
							levelAnim.SetTrigger ("4CW-3CCW");
							levelPos = 3;
						}
					//this.GetComponent<Rigidbody>().velocity = new Vector3(this.GetComponent<Rigidbody>().velocity.x, 0 , this.GetComponent<Rigidbody>().velocity.z);
					//this.GetComponent<Rigidbody>().AddForce(new Vector3(0, 100f,0));
				} 

					else if ((!swipedSideways && deltaY <= 0) && ((initialTouch.position.x) < mid) && level && bossBat == 4) {//swiped up on the left
						Debug.Log ("you swiped up on the left CW" + (initialTouch.position.x));


						if (levelPos == 0 || levelPos == 1) {
							Debug.Log (levelPos);
							if (levelPos == 0) {
								Debug.Log ("at least it enters");
								levelAnim.SetTrigger ("idle-4");
							} 
							else if (levelPos == 1) {
								levelAnim.SetTrigger ("1CW-2CW");
							}
							levelPos = 2;
						}

						else if (levelPos == 2) {
							levelAnim.SetTrigger ("2CW-3CW");
							levelPos = 3;
						}

						else if (levelPos == 3) {
							levelAnim.SetTrigger ("3CW-4CW");
							levelPos = 4;
						}

						else if (levelPos == 4) {
							levelAnim.SetTrigger ("4CW-1CW");
							levelPos = 1;
						}
					}

				hasSwiped = false;
			}
			} 
			else if (t.phase == TouchPhase.Ended) {
				initialTouch = new Touch ();
				hasSwiped = true;
			}
			
		
			
			
			//if(Input.touchCount >0){
			
			//}
			
			//Debug.Log ("This is the touch count " + Input.touchCount);
			
			//if(Input.GetKey(KeyCode.G)){
			//	canSitR = true;
			//	SitRight();
			//	}
			
		}
		
		
		
	}



}


