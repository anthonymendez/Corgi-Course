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
	void OnEnable () {

        if(GameController.gameScore > highScore) {
            highScore = GameController.gameScore;
            thisText.text = highScore + "";
            PlayerPrefs.SetInt("HighScore",highScore);
            newHighScore.gameObject.SetActive(true);
        } else {
            newHighScore.gameObject.SetActive(false);
        }

	}
}
