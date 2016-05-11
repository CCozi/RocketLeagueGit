using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	private Animator animator;
	private Rigidbody body;
	private InputState inputState;
	public bool faceright;
	public bool faceleft;
	public bool facedown;
	public bool faceup;
	
	
	void Awake(){
		body = GetComponent<Rigidbody> ();
		inputState = GetComponent<InputState> ();
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update() {
		
		
		if (inputState.right)
		{
			body.velocity = new Vector3(10, 0);
			faceright = true;
			facedown = false;
			faceleft = false;
			faceup = false;
		}
		if (inputState.upRelease)
		{
			body.velocity = new Vector3(0, 0);
		}
		if (inputState.downRelease)
		{
			
			body.velocity = new Vector3(0, 0);
			
		}
		if (inputState.leftRelease)
		{
			
			body.velocity = new Vector3(0, 0);
		}
		
		
		
		if (inputState.rightRelease)
		{
			body.velocity = new Vector3(0, 0);
		}
		
		
		if (inputState.left)
		{
			body.velocity = new Vector3(-10, 0);
			faceleft = true;
			facedown = false;
			faceright = false;
			faceup = false;
		}
		if (inputState.up)
		{
			body.velocity = new Vector3(0,0,10);
			faceup = true;
			facedown = false;
			faceleft = false;
			faceright = false;
		}
		if (inputState.down) {
			body.velocity = new Vector3 (0, 0, -10);
			facedown = true;
			faceright = false;
			faceleft = false;
			faceup = false;
		}
			if (inputState.Jump) {
			body.velocity = new Vector3 (0, 10, -0);
			facedown = false;
			faceright = false;
			faceleft = false;
			faceup = false;
		}
			if (inputState.Boost)
			{
				body.velocity = new Vector3(0,0, 20);
				facedown = true;
				faceright = false;
				faceleft = false;
				faceup = false;
		} 
	} 
}
