using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	
	public float points = 0;
	public GameObject thief;
	public GameObject detective;
	private Thief thiefScript;
	private Detective detectiveScript;
	Text text;
	
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		thief = GameObject.Find ("kuckles_tails_thief");
		detective = GameObject.Find ("sanic_detective");
		thiefScript = thief.GetComponent<Thief> ();
		detectiveScript = detective.GetComponent<Detective> ();
		text.text = "HELLOOOOOOO";
	}
	
	// Update is called once per frame
	void Update () {
		float totalpoints = thiefScript.points + detectiveScript.points;
		text.text = "Current points: " + totalpoints;
	}
}