using UnityEngine;
using System.Collections;

public class Detective : MonoBehaviour {
	public float jumpForce = 100f;
	public float moveSpeed = 10f;
	
	public float addPoints = 20;
	
	public static float points = 0;

	public bool grounded = true;
	
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

	}

	void FixedUpdate() {
		print("Grounded is " + grounded);
		print ("Velocity is " + rigidbody2D.velocity.y);
		// Jump
		if(grounded && Input.GetKey (KeyCode.W)) {
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
		}
		if (rigidbody2D.velocity.y >= 2) {
			grounded = false;
				}

	}

	//void OnCollisionEnter2D(Collision2D collision){

	//	}


	void OnCollisionStay2D(Collision2D collision) {
		if (collision.gameObject.name == "ground") {
						grounded = true;
				}

		if (collision.gameObject.name == "collectable" && Input.GetKey (KeyCode.E)) {
			points += addPoints;
			Destroy (collision.gameObject);
			print("Current points " + points);
		}
	}
}
