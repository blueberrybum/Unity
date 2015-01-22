#pragma strict

function Start () {

}


var degrees = 1;
var target : Transform;
var planet : Transform; 
 
function Update() {
 
     transform.RotateAround (target.position, Vector3.up, degrees);
     transform.RotateAround (target.position, Vector3.forward, degrees);
     transform.LookAt(planet);
      transform.position.z = 0;
      transform.rotation.z = 0;


}