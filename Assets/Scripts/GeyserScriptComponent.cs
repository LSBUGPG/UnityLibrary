using UnityEngine;
using System.Collections;

public class GeyserScriptComponent : MonoBehaviour {

	public GameObject GeyserParticle;
	public GameObject GeyserLight;

	public HealthManagerComponent PlayerHPManager;
	public DamageValues  Dvs;

	public int DurationActive = 10;
	public int Cooldown = 20;
	private int Count = 0;
	public bool isEnabled = false;
	// Use this for initialization

	// DOESN'T WORK STILL, PLZ USE PREWARM FOR PARTICLES.

	private int getRandomStartTime (){
		int  rngStart = Random.Range (1, 10);
		int returnValue = 0;
		if (rngStart == 1) {
			returnValue = 60;
		}else if (rngStart == 2) {
			returnValue = 120;
		}else if (rngStart == 3) {
			returnValue = 180;
		}else if (rngStart == 4) {
			returnValue = 240;
		}else if (rngStart == 5) {
			returnValue = 300;
		}else if (rngStart == 6) {
			returnValue = 360;
		}else if (rngStart == 7) {
			returnValue = 420;
		}else if (rngStart == 8) {
			returnValue = 480;
		}else if (rngStart == 9) {
			returnValue = 540;
		}else if (rngStart == 10) {
			returnValue = 600;
		}
		return returnValue;
	}

	void Start () {
		GeyserLight.GetComponent<Light> ().enabled = false;
		GeyserParticle.GetComponent<ParticleSystem> ().Stop ();
		Count = getRandomStartTime (); // Randomly start at a different time
	}

	// Update is called once per frame
	void Update () {
		Count = Count + 1;
		if (Count/60 >= Cooldown) {
			Count = 0;
			ActivateGeyeser ();
		}
	}

	private void SetGeyserEffects(bool Val){
		GeyserLight.GetComponent<Light>().enabled = Val;
		if (Val == true) {
			GeyserParticle.GetComponent<ParticleSystem> ().Play ();
		}else{
			GeyserParticle.GetComponent<ParticleSystem> ().Stop ();
		}
	}

	void ActivateGeyeser(){
		SetGeyserEffects (true);
		isEnabled = true;
		Invoke ("DisableGeyser", DurationActive);
		//Shoot thing
		//Make Damage thing active
	}

	void DisableGeyser(){
		//Disable damage thing
		SetGeyserEffects (false);
		isEnabled = false;
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player" && isEnabled == true) {
			PlayerHPManager.SubtractHealth(Dvs.GetGeyserDamage());
		}
	}
}
