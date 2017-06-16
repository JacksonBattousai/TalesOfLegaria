using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

	public string dialog;
	public GameObject img;
	private DialogueManager dMan;

	void Start () {
		
		dMan = FindObjectOfType<DialogueManager>();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D other){
	
		if (other.gameObject.name == "playerAC") {
			if (Input.GetKeyUp (KeyCode.Space)) {
				
				dMan.ShowBox (dialog);


			}
		}
	}

}
