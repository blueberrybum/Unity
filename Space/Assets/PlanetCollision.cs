using UnityEngine;
using System.Collections;

public class PlanetCollision : MonoBehaviour {
	public float timer = 10.0f;
	public bool machine;
	public bool laser;
	public bool forcefield;
	public bool bomb;
	public bool something;
	public bool bat;
	public GameObject gun;

	public void Start(){
		machine = false;
		laser = false;
		forcefield = false;
		bomb = false;
		something = false;
		}
	public void Update(){
		 if (machine == true) {
			bat = true;
				}

		}

	public void OnCollisionStay2D(Collision2D otherCollider2D)
	{
		
		
		if (otherCollider2D.gameObject.tag == "GreenPlanet"){
			timer -= Time.deltaTime;
			
		}
		if (otherCollider2D.gameObject.tag == "GreenPlanet" && timer <= -0){

			machine = true;
			
		}
		if (otherCollider2D.gameObject.tag == "BluePlanet"){
			timer -= Time.deltaTime;
			
		}
		if (otherCollider2D.gameObject.tag == "BluePlanet" && timer <= -0){
			laser = true;
			
		}
		if (otherCollider2D.gameObject.tag == "OrangePlanet"){
			timer -= Time.deltaTime;
			
		}
		if (otherCollider2D.gameObject.tag == "OrangePlanet" && timer <= -0){
			forcefield = true;
			
		}
		if (otherCollider2D.gameObject.tag == "PurplePlanet"){
			timer -= Time.deltaTime;
			
		}
		if (otherCollider2D.gameObject.tag == "PurplePlanet" && timer <= -0){
			bomb = true;
			
		}
		if (otherCollider2D.gameObject.tag == "PinkPlanet"){
			timer -= Time.deltaTime;
			
		}
		if (otherCollider2D.gameObject.tag == "PinkPlanet" && timer <= -0){
			something = true;
			
		}
	}
}
