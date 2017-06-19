	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collection : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("Era para desaparecer");
	
			gameObject.SetActive(false);
		}
	}



