using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {
	public float timer = 10.0f;
	public bool machine;
	public bool laser;
	public bool forcefield;
	public bool bomb;
	public bool something;
	private float fireRate = .15f;
	private float nextFire = 0;
	private float bulletSpeed = 500f;

	public GameObject otherGameObject;
	public GameObject ThePrefab;
	public GameObject Bomb;
	public GameObject Rocket;


	public float speed = 20.0f;


	void Start () {
	
	}
	void Awake(){
	


		}
	

	void Update () {
		Debug.Log (timer);

		weapons ();
	




	}
	void OnCollisionStay2D(Collision2D otherCollider2D)
	{
	

		if (otherCollider2D.gameObject.tag == "GreenPlanet" ){
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
	public void weapons(){
		GameObject instance;
		
	
			if (Input.GetButtonDown ("A")) {
				
				
				nextFire = Time.time + fireRate;
				Debug.Log ("nf" + nextFire);
				instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
				instance.rigidbody2D.AddForce(transform.up * bulletSpeed);
				
			}
		if (machine == true) {
			if (Input.GetButtonDown ("B")) {
				nextFire = Time.time + fireRate;
				Debug.Log ("nf" + nextFire);
				instance = Instantiate(Bomb, transform.position, transform.rotation) as GameObject;
				instance.rigidbody2D.AddForce(transform.up * bulletSpeed);

			}
		}
		if (bomb == true) {
			if (Input.GetButtonDown ("Y")) {
				nextFire = Time.time + fireRate;
				Debug.Log ("nf" + nextFire);
				instance = Instantiate(Rocket, transform.position, transform.rotation) as GameObject;
				instance.rigidbody2D.AddForce(transform.up * bulletSpeed);
				
			}
		}


	}

}