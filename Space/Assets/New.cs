using UnityEngine;
using System.Collections;

public class New : MonoBehaviour {

	public Upgrade other;
	public PlanetCollision who;
	public bool bat;
	public float timer = 10.0f;
	public bool machine;
	public bool laser;
	public bool forcefield;
	public bool bomb;
	public bool something;
	private float fireRate = .15f;
	private float nextFire = 0;
	private float bulletSpeed = 800f;

	public GameObject otherGameObject;
	public GameObject ThePrefab;
	public GameObject Bomb;
	public GameObject Rocket;
	
	void Start () {

	}
	void Awake(){
		GameObject go = GameObject.Find("Ship");

		PlanetCollision who = go.GetComponent<PlanetCollision> ();
	}
	
	// Update is called once per frame
	void Update () {


		GameObject instance;
		
		
//		if (Input.GetButtonDown ("A")) 
		if(Input.GetAxis("RightTrigger") == 1 && Time.time > nextFire)
		{
			
			
			nextFire = Time.time + fireRate;
			Debug.Log ("nf" + nextFire);
			instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
			instance.rigidbody2D.AddForce(transform.up * bulletSpeed);
			
		}
		if (who.machine == true) {
			if (Input.GetButtonDown ("B")) {
				nextFire = Time.time + fireRate;
				Debug.Log ("nf" + nextFire);
				instance = Instantiate(Bomb, transform.position, transform.rotation) as GameObject;
				instance.rigidbody2D.AddForce(transform.up * bulletSpeed);
				
			}
		}
		if (who.bomb == true) {
			if (Input.GetButtonDown ("Y")) {
				nextFire = Time.time + fireRate;
				Debug.Log ("nf" + nextFire);
				instance = Instantiate(Rocket, transform.position, transform.rotation) as GameObject;
				instance.rigidbody2D.AddForce(transform.up * bulletSpeed);
				
			}
		}
		
	}
}
