using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkMesh : MonoBehaviour {
	public GameObject Mesh;
	RigidbodyConstraints constraint;
	Rigidbody body;
	public FauxGravityAttractor attractor;
	private Transform myTransform;
	//Rigidbody body = GameObject.FindGameObjectWithTag("QB").GetComponent<Rigidbody>();

	void Start () {
		//Quaternion begin = new Quaternion (0, 0, 0,0);
		//QB.GetComponent<RigidbodyConstraints.FreezeRotation> ();
		//constraint = RigidbodyConstraints.FreezeRotation;
		//Mesh.GetComponent<Rigidbody>().useGravity = false;
		//Mesh.transform.rotation = begin;
		myTransform = transform;	
	}

	// Update is called once per frame
	void Update () {
		attractor.Attract(myTransform);

	}
}
