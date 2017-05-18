using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleAreaScript : MonoBehaviour {

    
    public float percentBattleFactor;
    public float timeToCheckBattle;

    private float currentTimeCheckBattle;

    public List<EnemyBehaviour> enemiesPrefab;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        if (GameController.GetCurrentState() != GAME_STATE.IN_EXPLORATION) return;
        currentTimeCheckBattle += Time.deltaTime;

        if (currentTimeCheckBattle > timeToCheckBattle)
        {
            currentTimeCheckBattle = 0;
            float randPercent = Random.Range(0, 100);

            if (randPercent <= percentBattleFactor)
            {
                
                Debug.Log("Teria que entrar em batalha");
                
                GameController.instance.ChangeState(GAME_STATE.IN_BATTLE);
                UIController.ShowFade();
                //Nessa etapa poderiamos criar um random para passar varios inimigos, mas como vamos mandar só um
                //ele esta sendo enviado no enemiesPrefabs na posição 0.
                
                BattleController.instance.SetBattle(enemiesPrefab[Random.Range(0,enemiesPrefab.Count)]);
            }

        }
    }

    void OnTriggerEnter(Collider obj) {
        Debug.Log("Colidiu");
        if (obj.CompareTag("PlayerMoviment"))
        {
            Debug.Log("Colidiu");
        }
    }

}
