using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextAdventure : MonoBehaviour {

	string currentRoom = "Lobby";
	int length = 0;
	// Use this for initialization
	void Start () {

	}

	bool hasBroccoli = false;
	void Update () {
		string textBuffer = "You are currently in: " + currentRoom;

		if (currentRoom == "Lobby") {
			textBuffer += "\nYou see the security guard.";
			textBuffer += "\npress [W] to go to elevators";
			textBuffer += "\npress [S] to go to outside";

			if (Input.GetKeyDown (KeyCode.W)) {
				currentRoom = "Elevators";
			} else if (Input.GetKeyDown (KeyCode.S)) {
				currentRoom = "Outside";
			}

		} else if (currentRoom == "Elevators") {
			textBuffer += "\n You're waiting.";
			if (hasBroccoli == false) {
				textBuffer += "\n You can't go in without your Broccoli, though...";
				textBuffer += "\n press [B] to go back";
				if (Input.GetKeyDown (KeyCode.B)) {
					currentRoom = "Lobby";
				}
			} else {
				textBuffer += "\n You show your Broccoli and the guard is fanscinated by it.";
				textBuffer += "\n press [C] to enter corridors";
				if (Input.GetKeyDown (KeyCode.C)) {
					currentRoom = "corridor";
				}

			}
		} else if (currentRoom == "Outside") {
			textBuffer += "\n WAH THERE ARE SO MUCH BROCCOLI OUTSIDE";
			textBuffer += "\n press [S] to go back INSIDE (But Why not have some nice broccoli?)";
			textBuffer += "\n press [R] to pick some broccoli";
			if (Input.GetKeyDown (KeyCode.R)) {
				hasBroccoli = true;
			}
			if (hasBroccoli == true) {
				textBuffer += "\n You picked some broccoli, not a bad choice";
			}
			if (Input.GetKeyDown (KeyCode.S)) {
				textBuffer += "\n You go back to the lobby";
				currentRoom = "Lobby";
			}
		} else if (currentRoom == "corridor" && length == 0) {
			textBuffer += "\n You heard the voice from room 1001 close to you.";
			textBuffer += "\n press [R] to go to room 1001";
			textBuffer += "\n press [W] to walk through";
			if (Input.GetKeyDown (KeyCode.R)) {
				textBuffer += "\n You go to room 1001";
				currentRoom = "Room1001";
			}
			if (Input.GetKeyDown (KeyCode.W)) {
				length = 1;
			}
		} else if (currentRoom == "corridor" && length == 1) {
			textBuffer += "\n You go forward and see a room with tag \"rest room\" ";
			textBuffer += "\n press [R] to come into the restroom";
			textBuffer += "\n press [B] to go back";
			if (Input.GetKeyDown (KeyCode.R)) {
				textBuffer += "\n You enter the restroom";
				currentRoom = "restroom";
			}
			if (Input.GetKeyDown (KeyCode.B)) {
				textBuffer += "\n You walk back";
				// TODO: more senario
				currentRoom = "corridor";
				length = 0;
			}
		} else if (currentRoom == "Room1001") {
			textBuffer += "\n You find a loot box, congratulations.";
		} else if (currentRoom == "restroom") {
			textBuffer += "\n You find some text written by lipstick";
			textBuffer += "\n '85274196'";
			textBuffer += "\n press [B] to goback";
			if (Input.GetKeyDown (KeyCode.B)) {
				textBuffer += "\n You go back to the corridor";
				// TODO: more senario
				currentRoom = "corridor";
				length = 1;
			}
		}
		GetComponent<Text> ().text = textBuffer;
	}
}
