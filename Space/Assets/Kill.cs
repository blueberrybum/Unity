using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour
{
	public GameObject ship;
	
	
	void Update ()
	{
		ship = GameObject.Find("Ship");
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player")
			Destroy(ship);

		
	}
}