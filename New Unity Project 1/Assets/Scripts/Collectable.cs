using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) { 
		if(other.gameObject.name == "detective" ||other.gameObject.name == "thief")
		{
			Destroy(gameObject.collider2D);
			gameObject.renderer.enabled = false;
			// Update global collectable/clue  count?
			Destroy(gameObject, 0.47f);
		}
	}
}