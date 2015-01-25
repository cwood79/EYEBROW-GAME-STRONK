using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization
	void OnGUI () 
	{
		const int buttonWidth = 84;
		const int buttonHeight = 60;
		
		if (GUI.Button (new Rect (Screen.width / 2 - (buttonWidth / 2),
		              (2 * Screen.height / 3) - (buttonHeight / 2),buttonWidth,buttonHeight),"Start")) 
		{
			Application.LoadLevel("Demo");
		}

	}
}
