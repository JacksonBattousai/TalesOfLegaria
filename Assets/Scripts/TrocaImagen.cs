using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TrocaImagen : MonoBehaviour {

	public TextBoxManega Teste; 
	public Image imageGO;

	TextBoxManega Testea = new TextBoxManega();
	// Use this for initialization
	void Start () {
		
	}

		
	// Update is called once per frame
	void Update () {
		


	if (Teste.currentLine == 0) {
		imageGO.sprite = Resources.Load<Sprite> ("Image1");
	} 
	
	if(Teste.currentLine == 1) {
			imageGO.sprite = Resources.Load<Sprite> ("Image2");
	}
	
	if (Teste.currentLine == 2) {
			imageGO.sprite = Resources.Load<Sprite> ("Image3");
	} 

	if (Teste.currentLine == 3) {
			imageGO.sprite = Resources.Load<Sprite> ("Image4");


	}
	



	
	
	}
	}


