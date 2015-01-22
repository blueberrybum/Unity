using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public float timer = 10.0f;
	public bool machine;
	public bool laser;
	public bool forcefield;
	public bool bomb;
	public bool something;

	public Collision2D sc;
	public PlanetCollision other;



	void Start () {

	
	}
	void Awake(){
	
	


	}

	void Update () {

		GameObject go = GameObject.Find("Ship");
		Upgrade other = go.GetComponent<Upgrade> ();

		other.weapons ();

	


	}

}
