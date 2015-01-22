using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour {
	void Update() {
		transform.RotateAround(Vector3.right , Vector3.left, 10 * Time.deltaTime);
	}
}