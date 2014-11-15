using UnityEngine;
using System.Collections;

public class Thief : MonoBehaviour {
	//private GameObject thief;
	private float jumpForce = 20;
	private float addPoints = 20;

	public static float points = 0;
	public float moveSpeed = 20;

	// Use this for initialization
	void Start () {
		//thief = GameObject.find("kuckles_tails_thief");
	}
	
	// Update is called once per frame
	void Update () {
		//float inputX = Input.GetAxis("Horizontal");

		if(Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
					}
		if(Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(new Vector3(-moveSpeed, 0, 0)* Time.deltaTime);
		}

		// Jump
		if(Input.GetKey (KeyCode.UpArrow)) {
			rigidbody2D.AddForce(new Vector2(0f, jumpForce));
			}
	}
		             

	void OnCollisionEnter2D(Collision2D collision) {
			if (collision.gameObject.name == "collectable") {
				points += addPoints;
				}
			/*if (collision.gameObject.tag == "bottom" && Input.GetKey (KeyCode.UpArrow)) {
				rigidbody2D.AddForce(new Vector2(0f, jumpForce));
		} */
			// unlock door
		//		if (Collision.GameObject.namespace == "door" &&  Input.getKey("RightShift"))// use action key) {

	//	}
			// climb ladder
			//if (collision.gameObject.namespace == "ladder" && Input.getKey("Up") {
	//	}
	}
}
