using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAreaScript : MonoBehaviour {

    
    public float percentBattleFactor;
    public float timeToCheckBattle;    

    public List<EnemyBehaviour> enemiesPrefab;
    private float currentTimeCheckBattle;
    
    private PlayerMoviment player;


    void Start () {
        player = FindObjectOfType(typeof(PlayerMoviment)) as PlayerMoviment;
        
    }
	
	// Update is called once per frame
	void Update () {

        if (GameController.GetCurrentState() != GAME_STATE.IN_EXPLORATION ) return;
        //era pra fazer o personagem ficar parado e não entrar em batalha.
        //if (GameController.GetCurrentState() != GAME_STATE.IN_EXPLORATION || player.GetComponent<Rigidbody>().velocity==Vector3.zero ) return;

//        currentTimeCheckBattle += Time.deltaTime;
//        
//
//        if (currentTimeCheckBattle > timeToCheckBattle)
//        {
//            currentTimeCheckBattle = 0;
//            float randPercent = Random.Range(0, 100);
//
//            if (randPercent <= percentBattleFactor)
//            {
//                
//                Debug.Log("Teria que entrar em batalha");
//                
//				//GameController.instance.ChangeState(GAME_STATE.IN_BATTLE);
//                //UIController.ShowFade();
//                //Nessa etapa poderiamos criar um random para passar varios inimigos, mas como vamos mandar só um
//                //ele esta sendo enviado no enemiesPrefabs na posição 0.                
//                //BattleController.instance.SetBattle(enemiesPrefab[Random.Range(0,enemiesPrefab.Count)]);
//                
//            }
//
//        }
    }

    void OnTriggerEnter2D(Collider2D obj) {
        if (obj.CompareTag("Player"))
        {
			GameController.instance.ChangeState(GAME_STATE.IN_BATTLE);
			UIController.ShowFade();
			//Nessa etapa poderiamos criar um random para passar varios inimigos, mas como vamos mandar só um
			//ele esta sendo enviado no enemiesPrefabs na posição 0.                
			BattleController.instance.SetBattle(enemiesPrefab[Random.Range(0,enemiesPrefab.Count)]);
        }
    }

}
