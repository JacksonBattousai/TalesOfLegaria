using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeBase : MonoBehaviour {


    public float life;

    private float currentLife;

    protected BattleController btController;

    public List<AttackBehaviour> attacks;

	protected void Awake () {
        currentLife = life;
        btController = FindObjectOfType(typeof(BattleController)) as BattleController;
	}
	
	// Update is called once per frame
	protected void Update () {
		
	}

    public void ApplyDamage(float damage)
    {
        currentLife -= damage;
        OnDamage();

        if (currentLife <= 0)
        {
            OnDie();
        }
    }

    public abstract void OnDamage();

    public abstract void OnDie();

    public float GetLife()
    {
        return currentLife;
    }
}
