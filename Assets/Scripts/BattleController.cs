using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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


	public Image BarraVida;
	//[Range(20,500)]
	public float VidaCheia=300;
	[HideInInspector]
	public float VidaAtual;
    // Use this for initialization

    void Awake () {
        instance = this;
        player = FindObjectOfType(typeof(PlayerMoviment)) as PlayerMoviment;


	}
	
	// Update is called once per frame
	void Update () {
		SistemadeVida ();
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
				Debug.Log(lastLifeEnemy);
            }
            else if(! isplayerTurn && lastLifePlayer != player.GetLife())
            {
                lastLifePlayer = player.GetLife();
                isplayerTurn = true;

				VidaAtual=lastLifePlayer;
				BarraVida.fillAmount = ((1 / VidaCheia) * VidaAtual);
					
            }
        }
	}

    public void SetBattle(EnemyBehaviour e)
    {   
        
        GameObject tempEnemy = Instantiate(e.gameObject, positionEnemy.position, positionEnemy.rotation);
        enemy = tempEnemy.GetComponent<EnemyBehaviour>();
        lastLifeEnemy = enemy.GetLife();
        lastPositionPlayer = player.transform.position;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		//player.transform.position = positionPlayer.position;
        lastLifePlayer = player.GetLife();
        isplayerTurn = true;
    }

    public void ExitBattle()
    {
        player.transform.position = lastPositionPlayer;
        if(enemy!=null) Destroy(enemy.gameObject);

        GameController.instance.ChangeState(GAME_STATE.IN_EXPLORATION);
        UIController.ShowFade();
    }


	void SistemadeVida(){
		if (VidaAtual >= VidaCheia) {
			VidaAtual = VidaCheia;
		} else if (VidaAtual <= 0) {
			VidaAtual = 0;
			Morreu ();
		}
	}
	void Morreu(){
		
	}
}
