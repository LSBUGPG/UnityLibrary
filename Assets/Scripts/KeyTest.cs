using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class KeyTest : MonoBehaviour {

	public Toggle toggle;
	public Text label;
	public KeyCode code;

	// Use this for initialization
	void Start () {
	
		label.text = code.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
		toggle.isOn = Input.GetKey (code);
	}
}
