using UnityEngine;
using System.Collections;



public class Door : MonoBehaviour {

	public static bool open = false;
	public GameObject thief;
	public GameObject detective;

	// Use this for initialization
	void Start () {
		thief = GameObject.Find("kuckles_tails_thief");
		detective = GameObject.Find("sanic_detective");
	}
	
	// Update is called once per frame
	void Update () {
		if(open == true)
		{
			print ("DOOR OPEN");
			//this.GetComponent<SpriteRenderer>.Color = Color.green;
			Physics2D.IgnoreCollision(thief.collider2D, this.collider2D);
				Physics2D.IgnoreCollision(detective.collider2D, this.collider2D);

		}
	
	}

	void openDoor () {

		if(open == false)
		{
			open = true;
		}

	}



}
