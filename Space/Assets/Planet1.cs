using UnityEngine;
using System.Collections;

public class Planet1 : MonoBehaviour {
	public bool green;
	public bool blue;
	public bool orange;
	public bool purple;
	public bool pink;
	public float speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2 ( rigidbody2D.velocity.y, Input.GetAxis ("Vertical") * speed);

	}
	public void OnTriggerStay2D(Collider2D otherCollider2D)
	{
		
		
		if (otherCollider2D.gameObject.tag == "GreenPlanet"){
			green = true;
			
		}
	
		if (otherCollider2D.gameObject.tag == "BluePlanet"){

			blue = true;
		}
	
		if (otherCollider2D.gameObject.tag == "OrangePlanet") {
			orange = true;
				}

		if (otherCollider2D.gameObject.tag == "PurplePlanet"){
			purple = true;
			
		}
	
		if (otherCollider2D.gameObject.tag == "PinkPlanet"){
			pink = true;

			
		}

	}
	public void OnTriggerExit2D(Collider2D otherCollider2D)
	{
		if (otherCollider2D.gameObject.tag == "GreenPlanet"){
			green = false;
			
		}
		
		if (otherCollider2D.gameObject.tag == "BluePlanet"){
			
			blue = false;
		}
		
		if (otherCollider2D.gameObject.tag == "OrangePlanet") {
			orange = false;
		}
		
		if (otherCollider2D.gameObject.tag == "PurplePlanet"){
			purple = false;
			
		}
		
		if (otherCollider2D.gameObject.tag == "PinkPlanet"){
			pink = false;
			
			
		}
		}
}
