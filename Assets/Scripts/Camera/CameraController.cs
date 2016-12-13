using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Camera[] cameras;
    public int roomNum = 1;

	// Use this for initialization
	void Start () {
 
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.Q) && roomNum == 1) {
			
			cameras [0].gameObject.SetActive (!cameras [0].gameObject.activeSelf);
			cameras [1].gameObject.SetActive (!cameras [1].gameObject.activeSelf);
		}

        if (Input.GetKeyDown(KeyCode.Q) && roomNum == 2)
        {
            cameras[2].gameObject.SetActive(!cameras[2].gameObject.activeSelf);
            cameras[3].gameObject.SetActive(!cameras[3].gameObject.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.Q) && roomNum == 3)
        {
            cameras[4].gameObject.SetActive(!cameras[4].gameObject.activeSelf);
            cameras[5].gameObject.SetActive(!cameras[5].gameObject.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.Q) && roomNum == 4)
        {
            cameras[6].gameObject.SetActive(!cameras[6].gameObject.activeSelf);
            cameras[7].gameObject.SetActive(!cameras[7].gameObject.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.Q) && roomNum == 5)
        {
            cameras[8].gameObject.SetActive(!cameras[8].gameObject.activeSelf);
            cameras[9].gameObject.SetActive(!cameras[9].gameObject.activeSelf);
        }

        // Below is all the code which is used to swap rooms

        if (Input.GetKeyDown (KeyCode.Alpha1) && roomNum !=1)
        {
            roomNum = 1;
            cameras[0].gameObject.SetActive(true);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(false);
            cameras[3].gameObject.SetActive(false);
            cameras[4].gameObject.SetActive(false);
            cameras[5].gameObject.SetActive(false);
            cameras[6].gameObject.SetActive(false);
            cameras[7].gameObject.SetActive(false);
            cameras[8].gameObject.SetActive(false);
            cameras[9].gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && roomNum != 2)
        {
            roomNum = 2;
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(true);
            cameras[3].gameObject.SetActive(false);
            cameras[4].gameObject.SetActive(false);
            cameras[5].gameObject.SetActive(false);
            cameras[6].gameObject.SetActive(false);
            cameras[7].gameObject.SetActive(false);
            cameras[8].gameObject.SetActive(false);
            cameras[9].gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && roomNum != 3)
        {
            roomNum = 3;
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(false);
            cameras[3].gameObject.SetActive(false);
            cameras[4].gameObject.SetActive(true);
            cameras[5].gameObject.SetActive(false);
            cameras[6].gameObject.SetActive(false);
            cameras[7].gameObject.SetActive(false);
            cameras[8].gameObject.SetActive(false);
            cameras[9].gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && roomNum != 4)
        {
            roomNum = 4;
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(false);
            cameras[3].gameObject.SetActive(false);
            cameras[4].gameObject.SetActive(false);
            cameras[5].gameObject.SetActive(false);
            cameras[6].gameObject.SetActive(true);
            cameras[7].gameObject.SetActive(false);
            cameras[8].gameObject.SetActive(false);
            cameras[9].gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && roomNum != 5)
        {
            roomNum = 5;
            cameras[0].gameObject.SetActive(false);
            cameras[1].gameObject.SetActive(false);
            cameras[2].gameObject.SetActive(false);
            cameras[3].gameObject.SetActive(false);
            cameras[4].gameObject.SetActive(false);
            cameras[5].gameObject.SetActive(false);
            cameras[6].gameObject.SetActive(false);
            cameras[7].gameObject.SetActive(false);
            cameras[8].gameObject.SetActive(true);
            cameras[9].gameObject.SetActive(false);
        }
    }
}