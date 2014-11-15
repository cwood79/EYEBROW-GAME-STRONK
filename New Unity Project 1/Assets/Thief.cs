using UnityEngine;
using System.Collections;

public class Thief : MonoBehaviour {
	//private GameObject thief;
	public float jumpForce = 30f;
	public float jumpTime = 0.5f;
	public float moveSpeed = 20f;
	
	public float addPoints = 20;

	public static float points = 0;


	// Use this for initialization
	void Start () {
		//thief = GameObject.find("kuckles_tails_thief");
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.RightArrow)) {
			transform.Translate(new Vector3(moveSpeed, 0, 0) * Time.deltaTime);
					}
		if(Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate(new Vector3(-moveSpeed, 0, 0)* Time.deltaTime);
		}

		// Jump
		if(Input.GetKey (KeyCode.UpArrow)) {
			rigidbody2D.AddForce(Vector3.up * jumpForce);
			}
	}
		             

	void OnCollisionEnter2D(Collision2D collision) {
			if (collision.gameObject.name == "collectable"){// && Input.GetKey (KeyCode.RightShift)) {
				points += addPoints;
				Destroy (collision.gameObject);
				print("Current points " + points);
				}
			//if (collision.gameObject.name == "bottom" && Input.GetKey (KeyCode.UpArrow)) {
			//	rigidbody2D.AddForce(Vector3.up * jumpForce);
			//	} 
			// unlock door
		//		if (Collision.GameObject.namespace == "door" &&  Input.getKey("RightShift"))// use action key) {

	//	}
			// climb ladder
			//if (collision.gameObject.namespace == "ladder" && Input.getKey("Up") {
	//	}
	}
}
