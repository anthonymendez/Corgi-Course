using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {

    Text thisText;

	// Use this for initialization
	void Start () {
        thisText = GetComponent<Text>();
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (GameController.inGame) {
            thisText.text = "" + GameController.gameScore;
        } else {
            gameObject.SetActive(false);
        }
	}
}
