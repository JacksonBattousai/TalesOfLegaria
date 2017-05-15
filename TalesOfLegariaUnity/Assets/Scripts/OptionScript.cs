using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionScript : MonoBehaviour {

    private void OnGUI()
    {
        const int buttonWidth = 100;
        const int buttonHeight = 60;

        if (GUI.Button(
            new Rect(Screen.width / 15 - (buttonWidth / 2),
                    (3 * Screen.height /3.2f ) - (buttonWidth /3),
                    buttonWidth, buttonHeight),
            "Opções!"))
        {
            Application.LoadLevel("Nome da Cena a transitar");
        }




    }



}
