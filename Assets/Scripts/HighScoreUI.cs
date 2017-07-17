using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUI : MonoBehaviour {

    public Text newHighScore;
    Text thisText;
    int highScore;

	// Use this for initialization
	void Start () {
        thisText = GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("HighScore");
	}

	// Called when enabled
	void Update () {

        if(GameController.gameScore > highScore) {
            highScore = GameController.gameScore;
            thisText.text = GameController.gameScore + "";
            PlayerPrefs.SetInt("HighScore", GameController.gameScore);
        } else {
            thisText.text = highScore + "";
        }

    }
}
