using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour {

Rigidbody2D rbody;
 Animator anim;
	// Use this for initialization
	void Start () {
		
		rbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        if (GameController.GetCurrentState() != GAME_STATE.IN_EXPLORATION) return;

		Vector2 moviment_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		if(moviment_vector!= Vector2.zero){
			anim.SetBool ("iswalking",true);
			anim.SetFloat ("input_x", moviment_vector.x);
			anim.SetFloat ("input_y", moviment_vector.y);

		} else{
			
			anim.SetBool ("iswalking", false); 
		}

		rbody.MovePosition (rbody.position + moviment_vector * Time.deltaTime*70);

}


}
