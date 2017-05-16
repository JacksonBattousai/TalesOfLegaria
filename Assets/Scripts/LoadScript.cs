using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScript : MonoBehaviour {
    private void OnGUI()
    {
        const int buttonWidth = 100;
        const int buttonHeight = 60;

        if (GUI.Button(
            new Rect(Screen.width / 15 - (buttonWidth / 2),
                    (3 * Screen.height / 4) - (buttonWidth / 6),
                    buttonWidth, buttonHeight),
            "Carregar!"))
        {
            Application.LoadLevel("Nome da Cena a transitar");
        }




    }

}
