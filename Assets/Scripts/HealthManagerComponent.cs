using UnityEngine;
using System.Collections;

public class HealthManagerComponent : MonoBehaviour {

	public MainGameManagerHPBar MGM;

	public GameObject SpawnPoint;

	public DamageValues DVs;


	public float PlayerRegenAmount = 1;
	public float PlayerRegenFrequency = 120; //Per tick / second (60 FPS)

	private float HPRegenCount = 0;

	public bool cursorLocked = true;

	public bool PlayerDied = false;
	private float health = 0;
	private float maxhealth = 0;

	// Use this for initialization

	void Start () {
		RespawnCharacter ();
	}

	// Update is called once per frame
	void Update () {
		if (health < maxhealth) {
			if (health <= 0) {
				if (PlayerDied == false) {
					PlayerDied = true;
					RespawnCharacter ();
					cursorLocked = false;
				} 
			} else {
				HPRegenCount = HPRegenCount + 1;
				if (HPRegenCount >= PlayerRegenFrequency) {
					HPRegenCount = 0;
					health = health + PlayerRegenAmount;
				}
				if (health > maxhealth) {
					health = maxhealth;
				}
			}
		}
		if (cursorLocked) {
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			//cursorLocked = true;
		} else {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			//cursorLocked = false;
		}
	}		
	public void RespawnCharacter(){
		PlayerDied = false;
		transform.position = SpawnPoint.transform.position;
		SetMaxHealth (100);
		SetHealth (100);
	}

	public float GetHealth(){
		return health;
	}
	public float GetMaxHealth(){
		return maxhealth;
	}

	public void SetMaxHealth(float hpSetAmnt){
		maxhealth = hpSetAmnt;
	}

	public void SetHealth(float hpSetAmnt){
		health = hpSetAmnt;
	}	

	public void SubtractHealth(float amnt){
		health = health  - amnt;
	}

	public void AddHealth(float  amnt){
		health = health + amnt;
	}
		

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "LavaWeak") {
			SubtractHealth (DVs.GetLavaDamage("LavaWeak"));
		}else if(collision.gameObject.tag == "LavaStrong"){
			SubtractHealth (DVs.GetLavaDamage("LavaStrong"));
		}else if(collision.gameObject.tag == "LavaUltimate"){
			SubtractHealth (DVs.GetLavaDamage("LavaUltimate"));
		}else if(collision.gameObject.tag == "Rocks"){
			SubtractHealth (DVs.GetRocksDamage());
			Destroy (collision.gameObject);
		}else if(collision.gameObject.tag == "Boulder"){
			SubtractHealth (DVs.GetBoulderDamage());
			Destroy (collision.gameObject);
		}else if(collision.gameObject.tag == "Geyser"){
			SubtractHealth (DVs.GetGeyserDamage());
		}
	}
}
