using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rot : MonoBehaviour {
	public Transform world;
	public GameObject QB;
	public int speed = 1;
	public int speed2;
	float currentAngle;
	private Touch initialTouch = new Touch();
	float distance;
	bool start = true;
	float duration = 0.1f;
	private bool hasSwiped = true;
	public float moveSpeed;
	private Vector3 moveDir;
	public Transform target;
	int origin = 0;
	int prevSwipe;
	int direction;
	int camPosition = 4;
	int Layer = 0;
	float LayerDist = 38f;
	int PrevLayer = 0;
	float QBY = 0;
	bool left = false;
	bool right = false;
	bool front = false;
	bool back = false;
	// Use this for initialization
	void Start () {
		moveDir = QB.GetComponent<Rigidbody>().position;
		/*Radius    Circumference
		 * 0.62		
		 * 1.25		7.85
		 */
	}

	// Update is called once per frame
	void Update () {

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
						Debug.Log ("works");
						prevSwipe = 1;
						direction = 1;
						camPosition = 2;
		
						if (origin == 0 && Layer == 0) {
							QB.transform.Translate (0, 0, 0.3f);

							origin++;
						}
						else if(Layer == 1) {
							Vector3 relativePos = (world.position + new Vector3(0, -0.2762071f, 0)) - QB.transform.position;
							Quaternion rotation = Quaternion.LookRotation (relativePos);
							Quaternion current = QB.transform.localRotation;
							QB.transform.localRotation = Quaternion.Slerp (current, rotation, Time.deltaTime);
							QB.transform.Translate (0,0,9 * Time.deltaTime);
							//QB.transform.Rotate (0, -30f, 0, Space.Self);
							//StartCoroutine (wait (prevSwipe, LayerDist));
							//QB.transform.Translate (0, 0, 40f * Time.deltaTime);
							//Debug.Log("First Turn");
						}

					}
					else if ((swipedSideways && deltaX <= 0)) {//swipe right
						prevSwipe = 2;
						camPosition = 1;
						if (origin == 0) {
							QB.transform.Translate (0, 0, -0.3f);

							origin++;
						} 
						else {
							QB.transform.Translate (0, 0, -40f * Time.deltaTime);
						}
					} 











					else if (!swipedSideways && deltaY <= 0) {//swipe up
						
						//prevSwipe = 3;
						camPosition = 4;
						if (origin == 0) {
							prevSwipe = 3;
							QB.transform.Translate (0.9f, 0, 0);
							Debug.Log ("Origin is " + origin);
							origin++;
							QBY = QB.GetComponent<Rigidbody> ().position.y;
							Debug.Log ("QBY is " + QBY);
						} 

						if (prevSwipe == 1) {//left
							//	QB.transform.Translate (0, 0, 40f * Time.deltaTime);
							Vector3 relativePos = (world.position + new Vector3(0, QBY, 0)) - QB.transform.position;
							Quaternion rotation = Quaternion.LookRotation (relativePos);
							Quaternion current = QB.transform.localRotation;
							QB.transform.localRotation = Quaternion.Slerp (current, rotation, Time.deltaTime);
							QB.transform.Translate (0,0, 9 * Time.deltaTime);

							if (Layer == 1) {
								//QB.transform.Rotate (0, -36f, 0, Space.Self);
							}

						} 
						else if (prevSwipe == 2) {//right
							//QB.transform.Translate (0, 0, -40f * Time.deltaTime);
							//QB.transform.Rotate (0, 14.4f, 0, Space.Self);
						} 
						else if (prevSwipe == 3 && camPosition == 4) {//up
							//QB.transform.Translate (40f * Time.deltaTime, 0, 0);
							PrevLayer = Layer;
							Layer++;
							if (Layer < 3) {
								LayerDist = LayerDist + 0.05f;
							} 
							else if(Layer >= 3 && Layer <= 6) {
								LayerDist = LayerDist + 0.15f;
							}
							Debug.Log ("Layer is " + Layer);
							//QB.transform.Rotate (0, -14.4f, 0, Space.Self);
						} 
						else if (prevSwipe == 4) {//down
							//QB.transform.Translate (-40f * Time.deltaTime, 0, 0);

							QB.transform.Rotate (0, 14.4f, 0, Space.Self);
						} 
						else {

							//Debug.Log ("shamamamamalala");

						}

						//StartCoroutine (wait (prevSwipe, LayerDist));
					}











					else if (!swipedSideways && deltaY > 0){//swipe down
						prevSwipe = 4;
						camPosition = 3;
						if (origin == 0) {
							QB.transform.Translate (-0.3f, 0, 0);

							origin++;
						} 
						else {
							QB.transform.Translate (-36f, 0, 0);
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

	/*void FixedUpdate(){
		QB.GetComponent<Rigidbody> ().MovePosition (QB.GetComponent<Rigidbody> ().position + transform.TransformDirection(0.2) * moveSpeed * Time.deltaTime);
	}*/

	IEnumerator wait(int prevSwipe, float LayerDist){
		yield return new WaitForSeconds (duration);
		if(prevSwipe == 1){//left
			QB.transform.Translate (0, 0,0.5f);

		}
		else if(prevSwipe == 2){//right
			QB.transform.Translate (0, 0, -1f * LayerDist * Time.deltaTime);

		}
		else if(prevSwipe == 3){//up
			QB.transform.Translate (0.5f, 0, 0);

		}
		else if(prevSwipe == 4){//down
			QB.transform.Translate (-1f * LayerDist * Time.deltaTime, 0, 0);

		}
	}
}


