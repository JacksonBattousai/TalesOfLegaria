using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {
    public Transform positionPlayer;
    public Transform positionEnemy;
    public bool isplayerTurn = true;
    public static BattleController instance;
    private PlayerMoviment player;
    public EnemyBehaviour enemy;
    private Vector3 lastPositionPlayer;
    private float lastLifeEnemy;
    private float lastLifePlayer;
    // Use this for initialization
    void Awake () {
        instance = this;
        player = FindObjectOfType(typeof(PlayerMoviment)) as PlayerMoviment;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            ExitBattle();

        if (enemy == null)
        {
            ExitBattle();
        }
        else
        {
            if(! isplayerTurn && enemy.GetLife() != lastLifeEnemy)
            {
                enemy.UseAttack();
                lastLifeEnemy = enemy.GetLife();
            }
            else if(! isplayerTurn && lastLifePlayer != player.GetLife())
            {
                lastLifePlayer = player.GetLife();
                isplayerTurn = true;
            }
        }
	}

    public void SetBattle(EnemyBehaviour e)
    {   
        
        GameObject tempEnemy = Instantiate(e.gameObject, positionEnemy.position, positionEnemy.rotation);
        enemy = tempEnemy.GetComponent<EnemyBehaviour>();
        lastLifeEnemy = enemy.GetLife();
        lastPositionPlayer = player.transform.position;
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.transform.position = positionPlayer.position;
        lastLifePlayer = player.GetLife();
        isplayerTurn = true;
    }

    public void ExitBattle()
    {
        player.transform.position = lastPositionPlayer;
        if(enemy!=null)Destroy(enemy.gameObject);

        GameController.instance.ChangeState(GAME_STATE.IN_EXPLORATION);
        UIController.ShowFade();
    }
}
