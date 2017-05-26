using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBehaviour : MonoBehaviour {

    public float damage;

    public float timeToLive;
    public float delayFactor;
    private float currentTimeToLive;

    private Vector3 positionToGo;
    private LifeBase target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        currentTimeToLive += Time.deltaTime;
        if (currentTimeToLive > timeToLive) {
            target.ApplyDamage(damage);
            Destroy(gameObject);
        }

        if (transform.position != positionToGo)
        {
            transform.position = Vector3.Lerp(transform.position, positionToGo, delayFactor);
        }

	}


    public void Use(LifeBase t)
    {
        positionToGo = t.transform.position;
        target = t;
    }

}
