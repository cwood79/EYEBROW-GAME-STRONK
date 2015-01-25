using UnityEngine;
using System.Collections;

public class Detective : MonoBehaviour {
	public float jumpForce = 100f; // vertical speed
	public float moveSpeed = 10f; // horizontal speed
	public const float ADD_POINTS = 20;
	
	public float points = 0;
	public const int MAX_V = 2;

	public bool grounded = true;

	public GameObject thief;

	// Use this for initialization
	void Start () {

		// allow detectie to pass through thief
		thief = GameObject.Find ("kuckles_tails_thief");
		Physics2D.IgnoreCollision( thief.collider2D, this.collider2D);
	}
	
	// Update is called once per frame
	void Update () {

		// move right
		if(Input.GetKey (KeyCode.D)) {
			this.transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
		}

		// move left
		if(Input.GetKey (KeyCode.A)) {
			this.transform.Translate(new Vector3(-moveSpeed, 0, 0)* Time.deltaTime);
		}

	}

	void FixedUpdate() {
		// Jump
		if(grounded && Input.GetKey (KeyCode.W)) {
			rigidbody2D.AddForce(new Vector2(0,jumpForce));
		}
		// controls length of jump
		if (rigidbody2D.velocity.y >= MAX_V) {
			grounded = false;
		}

	}


	void OnCollisionStay2D(Collision2D collision) {

		// allow player to jump
		if (collision.gameObject.name == "ground") {
						grounded = true;
		}

		// collect items
		if (collision.gameObject.name == "collectable" && Input.GetKey (KeyCode.E)) {
			points += ADD_POINTS;
			Destroy (collision.gameObject);
			print("Current points " + points);
		}
	}
}
