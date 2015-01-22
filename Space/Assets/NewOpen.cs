using UnityEngine;
using System.Collections;

public class NewOpen : MonoBehaviour {
	
	private Animator anim;
	
	public bool Shield;
	public bool Close;
	public bool Open;
	public float timer = 10.0f ;
	
	
	// Use this for initialization
	
	void Awake(){
		
		anim = GetComponent<Animator>();
		
		
	}
	void Start () {
		
		Shield = false;
		Close = false;
		Open = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		anim.SetBool("Shield", Shield);
		anim.SetBool ("Close", Close);
		anim.SetBool ("Open", Open);
		
		
		
		//		
	}
	void OnCollisionEnter2D(Collision2D otherCollider2D)
	{
		
		if (otherCollider2D.gameObject.tag == "Player"){
			
			Shield = true;
			Open = true;
			
			
			
			
			
			
			
			
			
		}
	}
	
}