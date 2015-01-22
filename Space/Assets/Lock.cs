using UnityEngine;
using System.Collections;

public class Lock : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float z = transform.eulerAngles.z;
		transform.Rotate(0, 0, -z);
		
	}
}
