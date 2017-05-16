using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAreaScript : MonoBehaviour {

    
    public float percentBattleFactor;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnTriggerStay(Collider obj) {
        Debug.Log("Colidiu");
        if (obj.GetComponent<PlayerMoviment>() != null)
        {
            Debug.Log("Colidiu");
        }
    }

}
