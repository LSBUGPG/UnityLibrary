using UnityEngine;
using System.Collections;

public class DamageValues : MonoBehaviour {

	private float LavaWeakDamage = 30;
	private float LavaStrongDamage = 60;
	private float LavaUltimateDamage = 300;
	private float BoulderDamage = 50;
	private float RocksDamage = 20;
	private float GeyserDamage = 40;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public float GetLavaDamage(string vType){
		if (vType == "LavaStrong") {
			return LavaStrongDamage;
		} else if (vType == "LavaWeak") {
			return LavaWeakDamage;
		}else if (vType == "LavaUltimate") {
			return LavaUltimateDamage;
		}else{
			return LavaUltimateDamage;
		}
	}

	public float GetRocksDamage(){
		return RocksDamage;
	}

	public float GetBoulderDamage(){
		return BoulderDamage;
	}
	public float GetGeyserDamage(){
		return GeyserDamage;
	}
}
