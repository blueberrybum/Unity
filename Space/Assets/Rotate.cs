using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour 
{
	public Transform target;
	
	
	void Update () 
	{
		Vector3 relativePos = (target.position + new Vector3(0, 100.0f, 0)) - transform.position;
		Quaternion rotation = Quaternion.LookRotation(relativePos);
		
		Quaternion current = transform.localRotation;
		
		transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime*5);
		transform.Translate(3 * Time.deltaTime, 0, 0);
	}
}