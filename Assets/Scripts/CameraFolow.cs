using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour {

	// Use this for initialization

	public Transform target;
	Camera mycam;

	void Start () {
	
		mycam = GetComponent<Camera>();

	}

	// Update is called once per frame
	void Update () {

		mycam.orthographicSize = (Screen.height / 1.5f) / 1f;
	
		if (target) {
			
			transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3(0,0,-10);
		}
	}

}
