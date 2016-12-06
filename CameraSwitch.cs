using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

	public Camera mainCamera;
	public Camera battleCamera;

	public GameObject battleMenu;
	private Vector3 startPos;
	private Vector3 startCharPos;
	private Quaternion startRot;
	private Quaternion startCharRot;
	public GameObject pa;
	public GameObject character;

	private FightManager fightManager;


	// Use this for initialization
	void Start () {

		fightManager = FindObjectOfType<FightManager> ();

		mainCamera.enabled = true;
		battleCamera.enabled = false;
		startPos = pa.transform.position;
		startCharPos = character.transform.position;
		startRot = pa.transform.rotation;
		startCharRot = character.transform.rotation;

		//print (gameObject.name);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		if (other.tag == "Player") 
		{
			mainCamera.enabled = !mainCamera.enabled;
			battleCamera.enabled = !battleCamera.enabled;
			battleMenu.SetActive (true);
			fightManager.enemy = gameObject;
			Restart ();
		}
	}

	public void Restart (){
		pa.transform.position = startPos;
		character.transform.position = startCharPos;
		pa.transform.rotation = startRot;
		character.transform.rotation = startCharRot;
		print ("Restart");
		print (gameObject.name);
	}

	public void LoadMainLevel(bool won){
		//SceneManager.LoadScene ("MainLevel");
		//battleMenu.SetActive (false);
		mainCamera.enabled = true;
		battleCamera.enabled = false;
		battleMenu.SetActive (false);


		if (won) {

			Destroy (transform.parent.gameObject);
		}
	}


}
