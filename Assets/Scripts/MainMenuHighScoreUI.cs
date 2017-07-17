using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuHighScoreUI : MonoBehaviour {

    Text thisText;

	// Use this for initialization
	void Start () {
        thisText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        thisText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
	}
}
