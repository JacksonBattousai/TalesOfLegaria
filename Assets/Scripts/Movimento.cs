using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour {
	Vector2 moviment_vector;

	private Animator anim;

	public float moveSpeed;

	private Rigidbody2D myRigidbody;

	private bool moving;

	public float timeBetweenMove;

	private float timeBetweenMoveCounter;

	public float timeToMove;

	private Vector3 moveDirection;

	private float timeToMoveCounter;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
		myRigidbody=GetComponent<Rigidbody2D> ();
		timeBetweenMoveCounter = timeBetweenMove;
		timeToMoveCounter = timeToMove;

	} 

	// Update is called once per frame
	void Update () {

		if (moving) 
		{
			timeToMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = moveDirection;

			anim.SetFloat ("Input_x", moveDirection.x);
			anim.SetFloat ("Input_y", moveDirection.y);

			if (timeToMoveCounter < 0f) 
				
			{


				moving = false;
				timeBetweenMoveCounter = timeBetweenMove; 


			}


		} else {
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = Vector2.zero;


			if (timeBetweenMoveCounter < 0f) 

				moving = true;
				timeToMoveCounter = timeToMove;

			moveDirection = new Vector3 (Random.Range (-1f, 1f) * moveSpeed, Random.Range (-1f, 1f) * moveSpeed, 0f);
				

			}


	}


}﻿
