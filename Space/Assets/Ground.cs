using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {
	
	public Transform groundCheck;
	public bool grounded = false;
	public bool balanced = false;
	
	// Use this for initialization
	public void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
		
		grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Planet"));
		
		
		if (grounded) {
			Debug.Log ("Hi");
			
		}
		
	}
	public void Awake()
	{
		
		groundCheck = transform.Find("groundCheck");
		
	}
}
