using UnityEngine;
using System.Collections;

public class Confirm : MonoBehaviour {

	public Planet1 why;
	public float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	void Awake(){

	}
	void Update () {

		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, Input.GetAxis ("Horizontal") * speed);

	}
	void OnTriggerStay2D(Collider2D col){
		GameObject go = GameObject.Find("Bottom");
		
		Planet1 why = go.GetComponent<Planet1> ();
		if (col.gameObject.tag == "GreenPlanet" && why.green == true){
			Debug.Log ("Green");
			
		}
		if (col.gameObject.tag == "OrangePlanet" && why.green == true){
			Debug.Log ("Orange");
			
		}
		if (col.gameObject.tag == "PinkPlanet" && why.green == true){
			Debug.Log ("Pink");
			
		}
		if (col.gameObject.tag == "PurplePlanet" && why.green == true){
			Debug.Log ("Purple");
			
		}
		if (col.gameObject.tag == "BluePlanet" && why.green == true){
			Debug.Log ("Blue");
			
		}
	}
}
