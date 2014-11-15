using UnityEngine;
using System.Collections;

public class Detective : MonoBehaviour {
	public float jumpForce = 15f;
	public float jumpTime = 0.25f;
	public float moveSpeed = 10f;
	
	public float addPoints = 20;
	
	public static float points = 0;
	
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey (KeyCode.D)) {
			this.transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.A)) {
			this.transform.Translate(new Vector3(-moveSpeed, 0, 0)* Time.deltaTime);
		}
		
		// Jump
		if(Input.GetKey (KeyCode.W)) {
			this.rigidbody2D.AddForce(Vector3.up * jumpForce);
		}
	}
	
	
	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.name == "collectable" && Input.GetKey (KeyCode.E)) {
			points += addPoints;
			Destroy (collision.gameObject);
			print("Current points " + points);
		}
	}
}
