using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {


	public Transform warpTarget;


	public void OnTriggerEnter2D(Collider2D other){
		
		Debug.Log ("colider!!!!");
		other.gameObject.transform.position = warpTarget.position;
		Camera.main.transform.position = warpTarget.position;
	
	}


}
