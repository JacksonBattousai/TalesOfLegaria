using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour {
    public Transform positionPlayer;
    public Transform positionEnemy;
    
    public static BattleController instance;
    private PlayerMoviment player;
    private EnemyBehaviour enemy;
    private Vector3 lastPositionPlayer;

	// Use this for initialization
	void Awake () {
        instance = this;
        player = FindObjectOfType(typeof(PlayerMoviment)) as PlayerMoviment;
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    public void SetBattle(EnemyBehaviour e)
    {
        Instantiate(e.gameObject, positionEnemy.position, positionEnemy.rotation);
        lastPositionPlayer = player.transform.position;
        player.transform.position = positionPlayer.position;
    }
}
