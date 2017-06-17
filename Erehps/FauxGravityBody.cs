using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour {
	public GameObject QB;
	RigidbodyConstraints constraint;
	Rigidbody body;
	public FauxGravityAttractor attractor;
	private Transform myTransform;
	//Rigidbody body = GameObject.FindGameObjectWithTag("QB").GetComponent<Rigidbody>();

	void Start () {
		//QB.GetComponent<RigidbodyConstraints.FreezeRotation> ();
		constraint = RigidbodyConstraints.FreezeRotation;
		QB.GetComponent<Rigidbody>().useGravity = false;
		myTransform = transform;	
	}
	
	// Update is called once per frame
	void Update () {
		attractor.Attract(myTransform);

	}
}
