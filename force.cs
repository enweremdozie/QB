using UnityEngine;
using System.Collections;

public class force : MonoBehaviour {
	public GameObject obs;
	ConstantForce getForce;


	void Start(){




	}



	void Update() {


		getForce = obs.GetComponent<ConstantForce>();
		StartCoroutine(MyMethod());

	
	
	
	
	}


	IEnumerator MyMethod() {

		yield return new WaitForSeconds(10);
		getForce.GetComponent<ConstantForce>().force = new Vector3(20, 0, 0);
	
	}

}
