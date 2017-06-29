using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFade : MonoBehaviour {

	Animator anim;
	bool isFading  = false;
	void Start () {
		anim=GetComponent<Animator>();

	}


	public IEnumerator FadetoClear(){
		isFading = true;
		anim.SetTrigger ("FadeIn");
		while (isFading)
			yield return null;
	}

	public IEnumerator FadetoBlack(){
		isFading = true;
		anim.SetTrigger ("FadeOut");
		while (isFading)
			yield return null;

	}
	// Update is called once per frame
	void AnimatorComplete () {
		isFading = false;
	}
}
