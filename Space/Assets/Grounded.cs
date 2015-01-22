using UnityEngine;
using System.Collections;

public class Grounded : MonoBehaviour {
	
	public Transform groundCheck;
	public bool grounded = false;
	public bool balanced = false;
	public bool machine;
	public bool laser;
	public bool forcefield;
	public bool bomb;
	public bool something;
	public PlanetCollision other;
	
	// Use this for initialization
	public void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
		
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Planet"));
//		other.GetComponent<PlanetCollision>().machine = false;

		
		if (grounded) {
			Debug.Log ("Hi");

		}
		
	}
	public void Awake()
	{
		
		groundCheck = transform.Find("groundCheck");
		
	}
}
