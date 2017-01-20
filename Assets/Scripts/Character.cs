using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    //-- NOTE: Public values can be accessed and changed in the Inspector over in Unity
    public float speed = 8.0f;
	public float groundspeed = 8.0f;
    public float rotationSpeed = 2.0f;

    public float jumpSpeed = 10.0f;
    public float gravity = 30.0f;

	public float thrust = 30.0f;
	public float fireRate = 1.0f;

    public float maxHeadRotation = 80.0f;
    public float minHeadRotation = -80.0f;

	public Camera camera;

    public Transform head;

    //-- NOTE: Private values cannot be accessed anywhere outside the script
    private float currentHeadRotation = 0;
    private float yVelocity = 0;

    private CharacterController controller;
    private Vector3 moveVelocity = Vector3.zero;
	private float retriggerTime = 0.0f;


    // Use this for initialization
    void Start () {
        controller = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update () {

        //-- Mouse Controls mapped to Inputs (Can be edited in Input Manager)
        Vector2 mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        //-- Ensures the Character cannot jump lest they are touching the ground
        if (controller.isGrounded)
        {
			//-- Movement functions mapped to key Inputs (Edited same as above)
			moveVelocity = transform.TransformDirection(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"))) * speed;

			yVelocity = 0;
			speed = groundspeed;

            if (Input.GetButtonDown("Jump"))
            {
                yVelocity = jumpSpeed;
				speed = speed /= 2f;
            }
        }

        //-- Gravity
        yVelocity -= gravity * Time.deltaTime;

        //-- Rotate the Character with the mouse movements
        transform.Rotate(Vector3.up, mouseInput.x * rotationSpeed);

        //-- Rotate the Head parented to the Character up and down within the set restritions of the min and max HeadRotation floats upon mouse movements
        currentHeadRotation = Mathf.Clamp(currentHeadRotation + mouseInput.y * rotationSpeed, minHeadRotation, maxHeadRotation);

        head.localRotation = Quaternion.identity;
        head.Rotate(Vector3.left, currentHeadRotation);

		retriggerTime -= Time.deltaTime;

		if (Input.GetMouseButtonDown (0) && retriggerTime < 0.0f) {

			Vector3 direction = -camera.transform.forward * thrust;
			yVelocity += direction.y;
			moveVelocity.x = direction.x;
			moveVelocity.z = direction.z;

			retriggerTime = fireRate;
		}

		Vector3 velocity = moveVelocity + yVelocity * Vector3.up;

		controller.Move(velocity * Time.deltaTime);

    }
}
