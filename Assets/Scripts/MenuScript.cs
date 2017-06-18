using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    public void NewGame()    
		{
            Application.LoadLevel("teste");
        }

	public void Sair(){
	
		Application.Quit();
	}

}
