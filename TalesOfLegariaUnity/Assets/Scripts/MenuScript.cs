using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    private void OnGUI()
    {
        const int buttonWidth = 100;
        const int buttonHeight = 60;

        if (GUI.Button(
            new Rect(Screen.width / 15 - (buttonWidth / 2),
                    (2 * Screen.height / 3) - (buttonWidth / 2),
                    buttonWidth, buttonHeight),
            "Start!"))
        {
            Application.LoadLevel("Nome da Cena a transitar");
        }




    }






}
