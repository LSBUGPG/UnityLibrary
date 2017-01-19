using UnityEngine;

public class NewBehaviour : MonoBehaviour {


	public Camera[] cams;


	public GameObject camera1;
	public GameObject camera2;
	public GameObject camera3;
	public GameObject camera4;
	public Texture texture;

	void Start() {
		camera1.SetActive(true);
		camera2.SetActive(false);
		camera3.SetActive(false);
		camera4.SetActive(false);        
	}

	void OnGUI() {
		if(GUI.Button(new Rect(0, 0, 100, 100), texture)) {
			camera1.SetActive(true);
			camera2.SetActive(false);
			camera3.SetActive(false);
			camera4.SetActive(false);
		}
		if(GUI.Button(new Rect(100, 0, 100, 100), texture)) {
			camera1.SetActive(false);
			camera2.SetActive(true);
			camera3.SetActive(false);
			camera4.SetActive(false);
		}
		if(GUI.Button(new Rect(200, 0, 100, 100), texture)) {
			camera1.SetActive(false);
			camera2.SetActive(false);
			camera3.SetActive(true);
			camera4.SetActive(false);
		}
		if(GUI.Button(new Rect(300, 0, 100, 100), texture)) {
			camera1.SetActive(false);
			camera2.SetActive(false);
			camera3.SetActive(false);
			camera4.SetActive(true);

		}
	}
}