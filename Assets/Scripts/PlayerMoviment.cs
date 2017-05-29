using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : LifeBase {

    private BattleController battleController;




Rigidbody2D rbody;
 Animator anim;
	// Use this for initialization
	void Start () {
        base.Awake();
		rbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
        battleController = BattleController.instance;
	}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            UseAttack();
        }
    }
    // Update is called once per frame
    void FixedUpdate () {

        if (GameController.GetCurrentState() != GAME_STATE.IN_EXPLORATION) return;

		Vector2 moviment_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

		if(moviment_vector!= Vector2.zero){
			anim.SetBool ("iswalking",true);
			anim.SetFloat ("input_x", moviment_vector.x);
			anim.SetFloat ("input_y", moviment_vector.y);

		} else{
			
			anim.SetBool ("iswalking", false); 
		}

		rbody.MovePosition (rbody.position + moviment_vector * Time.deltaTime*70);

}
    public override void OnDamage()
    {
        
    }

    public override void OnDie()
    {
        
    }


    public void UseAttack()
    {
        if (battleController.isplayerTurn) { 
            GameObject tempAttack=Instantiate(attacks[0].gameObject, transform.position,transform.rotation) as GameObject;
            tempAttack.GetComponent<AttackBehaviour>().Use(battleController.enemy);
            battleController.isplayerTurn = false;

        }
    }
}
