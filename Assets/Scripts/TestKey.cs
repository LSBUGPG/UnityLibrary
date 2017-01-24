using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestKey : MonoBehaviour {

    public Toggle state;
    public Text label;
    public KeyCode code;

	// Use this for initialization
	void Start () {

        label.text = code.ToString();
        name = code.ToString();
	}
	
	// Update is called once per frame
	void Update () {

        state.isOn = Input.GetKey(code);
	}
}
