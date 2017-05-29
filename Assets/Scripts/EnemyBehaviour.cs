using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : LifeBase {

    public EnemyBehaviour enemy;
    private PlayerMoviment player;
	// Use this for initialization
	void Start () {
        base.Awake();
        player = FindObjectOfType(typeof(PlayerMoviment)) as PlayerMoviment;
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();	
	}

    public override void OnDamage()
    {
       
    }

    public override void OnDie()
    {
        Destroy(gameObject);
    }


    public void UseAttack()
    {
        
            GameObject tempAttack = Instantiate(attacks[0].gameObject, transform.position, transform.rotation) as GameObject;
            tempAttack.GetComponent<AttackBehaviour>().Use(player);
            

        
    }

}
