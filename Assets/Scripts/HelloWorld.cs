﻿using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class HelloWorld : MonoBehaviour {

	public Text myTextObject;

	// Use this for initialization
	void Start () {
		Debug.Log ("HelloWorld");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Bonjour Monde");
		myTextObject.text = "Hola Mundo";
	}
}
