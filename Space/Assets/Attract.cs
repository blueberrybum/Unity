
	using UnityEngine;
	using System.Collections;
	
	public class Attract : MonoBehaviour {
		
	public GameObject attractedTo;
	public float strengthOfAttraction = 5.0f;
	public bool magnet = false;
		
		void Start(){
		magnet = false;
	
		}
		void Update()

		{
		attractedTo = GameObject.Find("Black Hole");
		if (magnet == true){
			Vector3 direction = attractedTo.transform.position - transform.position;
			rigidbody2D.AddForce(strengthOfAttraction * direction);
		}

		}
	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.gameObject.tag == "Hole") {
		magnet = true;
		} 
	



	}
	void OnTriggerExit2D(Collider2D coll){

		if (coll.gameObject.tag == "Hole") {
			magnet = false;
		} 
		}

}