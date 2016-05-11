using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {
	
	public bool actionButton;
	public bool aRelease;
	public bool right;
	public bool rightRelease;
	public bool left;
	public bool leftRelease;
	public bool up; 
	public bool upRelease;
	public bool down;
	public bool downRelease;
	public bool running;
	public float absVelX = 0f;
	public float absVelY = 0f; 
	public float absVelZ = 0f;
	public bool standing;
	public bool Jump;
	public bool Boost;
	public float standingThreshold = 1f;
	
	
	private Rigidbody body;
	
	void Awake(){
		body = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		up = Input.GetKey(KeyCode.W);
		upRelease = Input.GetKeyUp (KeyCode.W);
		
		right = Input.GetKey(KeyCode.D);
		rightRelease = Input.GetKeyUp(KeyCode.D);
		
		
		left = Input.GetKey(KeyCode.A);
		leftRelease = Input.GetKeyUp(KeyCode.A);
		
		
		down = Input.GetKey(KeyCode.S);
		downRelease = Input.GetKeyUp(KeyCode.S);

		Jump = Input.GetKey(KeyCode.Space);
		downRelease = Input.GetKeyUp(KeyCode.Space);

		Boost = Input.GetKeyDown(KeyCode.LeftShift);
		downRelease = Input.GetKeyUp (KeyCode.LeftShift);
		
		actionButton = Input.GetKey(KeyCode.RightControl);
		aRelease = Input.GetKeyUp(KeyCode.RightControl);
		
		
		
	}
	void FixedUpdate(){
		absVelX = System.Math.Abs (body.velocity.x);
		absVelY = System.Math.Abs (body.velocity.y); 
		absVelZ = System.Math.Abs (body.velocity.z);
		
		standing = absVelY <= standingThreshold;
		
	}
	
} 

