using UnityEngine;
using System.Collections;



public class Control : MonoBehaviour {
	public float speed = 10;

	public bool Thrust;
	public bool gun;
	public bool laser;
	
	float PlayerRotationSpeed = 100;
	void Awake(){

		
		
	}
	void Start(){
		Thrust = false;
	}
	
	void FixedUpdate() {  

		SpaceshipControl ();
		
		
		
	}
	void SpaceshipControl(){
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, Input.GetAxis ("Horizontal") * speed);
		rigidbody2D.velocity = new Vector2 ( rigidbody2D.velocity.y, Input.GetAxis ("Vertical") * speed);
		transform.Rotate(0,0, Input.GetAxis("RightStick") * Time.deltaTime * PlayerRotationSpeed);
		
		if (Input.GetButtonDown ("A")) {
			speed = 40;
			StartCoroutine (Wait());
		}
		
		
		
		
	}
	IEnumerator Wait() {
		Thrust = true;
		yield return new WaitForSeconds(3.0f);
		Thrust = false;
		speed = 10;
	}
}