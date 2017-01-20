using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	public enum BattleStates
	{
		START,
		PLAYERACTION,
		ENEMYACTION,
		LOSE,
		WIN
	}

	private BattleStates currentState;

	// Use this for initialization
	void Start () {
		currentState = BattleStates.START;
	
	}
	
	// Update is called once per frame
	void Update () {
		switch (currentState) {
		case BattleStates.START:
			break;

		case BattleStates.PLAYERACTION:
			break;

		case BattleStates.ENEMYACTION:
			break;

		case BattleStates.LOSE:
			break;

		case BattleStates.WIN:
			break;
	
		}

	}

		void OnGUI (){

			if (GUILayout.Button("NEXT STATE")) {
				if (currentState == BattleStates.START) {
					currentState = BattleStates.PLAYERACTION;
				}
			}

		}
	}
