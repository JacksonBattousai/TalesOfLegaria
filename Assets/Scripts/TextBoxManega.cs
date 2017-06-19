using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextBoxManega : MonoBehaviour {

	public string[] textLine;
	public GameObject textBox;
	public TextAsset textFile;
	public Image imageGO;
	public int currentLine;
	public int endAtLine;


	public Text thetext;

		void Start () {
			if (textFile != null) {

			textLine = (textFile.text.Split('\n'));
			}
		if (endAtLine == 0) {
			endAtLine = textLine.Length - 1;
		}

		}

	
	// Update is called once per frame

	void Update () {

		thetext.text = textLine[currentLine];

		if (Input.GetKeyDown (KeyCode.Space)){

			currentLine += 1;

			/* if (currentLine == 1) {
					imageGO.sprite = Resources.Load<Sprite> ("Image5");
			} else if(currentLine == 2) {

						imageGO.sprite = Resources.Load<Sprite> ("Image2");
					}*/

		}


		if (currentLine > endAtLine) {
			
			Application.LoadLevel("teste");
		
		}



}

}