using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TapGame : MonoBehaviour {

	public Text myTextThing;

	int CurrentPoints = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// give palyer 1 point if they press Space
		if (Input.GetKeyDown (KeyCode.Space)) {
			CurrentPoints += 1;
			myTextThing.text = "CURRENT SCORE: " + CurrentPoints.ToString ();
		} 
		else if (Input.GetKeyDown (KeyCode.X)) {
			CurrentPoints += 1000;
			myTextThing.text = "CURRENT SCORE: " + CurrentPoints.ToString ();
		}
	}
}
