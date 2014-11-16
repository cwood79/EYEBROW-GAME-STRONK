using UnityEngine;
using System.Collections;

public class Thief : MonoBehaviour {
	//private GameObject thief;
	public float jumpForce = 550f;
	public float moveSpeed = 20f;
	
	public float addPoints = 20;
	
	public static float points = 0;

	public bool grounded = true;
	
	
	// Use this for initialization
	void Start () {
		//thief = GameObject.find("kuckles_tails_thief");
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(new Vector3(-moveSpeed, 0, 0)* Time.deltaTime);
		}

	}

	void FixedUpdate() {
		print("Grounded is " + grounded);
		print ("Velocity is " + rigidbody2D.velocity.y);
		// Jump
		if(grounded && Input.GetKey (KeyCode.UpArrow)) {
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
		}
		if (rigidbody2D.velocity.y >= 6) {
			grounded = false;
		}
		
	}
	
	
	void OnCollisionStay2D(Collision2D collision) {

		if (collision.gameObject.name == "ground") {
			grounded = true;
		}

		if (collision.gameObject.name == "collectable" && Input.GetKey (KeyCode.RightShift)) {
			points += addPoints;
			Destroy (collision.gameObject);
			print("Current points " + points);
		}

		if (collision.gameObject.name == "Door" && Input.GetKey (KeyCode.RightShift)) {
			collision.gameObject.SendMessage("openDoor");

		}
	}
}
