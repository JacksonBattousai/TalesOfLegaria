using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GAME_STATE
{
    IN_EXPLORATION,
    IN_BATTLE
}


public class GameController : MonoBehaviour {

    public BattleController battleArena;
    public Camera cameraExploration;

    private GAME_STATE currentState;
    private GAME_STATE nextState;

    public static GameController instance;

	// Use this for initialization
	void Start () {
        instance = this;
        ChangeState (GAME_STATE.IN_EXPLORATION);
	}
	
	// Update is called once per frame
	void Update () {
        currentState = nextState;
        switch (currentState)
        {
            case GAME_STATE.IN_EXPLORATION:
                {
                    break;
                }

            case GAME_STATE.IN_BATTLE:
                {
                    break;
                }
        }
	}

    public void ChangeState(GAME_STATE newState)
    {
        nextState = newState;
		Debug.Log("Estado" + newState);
        switch (nextState)
        {
            case GAME_STATE.IN_EXPLORATION:
                {
                    battleArena.gameObject.SetActive(false);
                    cameraExploration.gameObject.SetActive(true);
                    break;
                }

            case GAME_STATE.IN_BATTLE:
                {
                    battleArena.gameObject.SetActive(true);
                    cameraExploration.gameObject.SetActive(false);
                    break;
                }
        }

    }

    public static GAME_STATE GetCurrentState()
    {
        return instance.currentState;
    }
}
