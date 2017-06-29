using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Warp : MonoBehaviour {


	public Transform warpTarget;


	IEnumerator OnTriggerEnter2D(Collider2D other){

		ScreenFade af = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFade>();
		yield return StartCoroutine (af.FadetoBlack());

		other.gameObject.transform.position = warpTarget.position;
		Camera.main.transform.position = warpTarget.position;
		yield return StartCoroutine (af.FadetoClear());
	}


}
