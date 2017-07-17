using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreUI : MonoBehaviour {

    Text thisText;
    int highScore;

	// Use this for initialization
	void Start () {
        thisText = GetComponent<Text>();
        thisText.text = "" + GameController.gameScore;
	}
	
	// Update is called once per frame
	void Update () {
        thisText.text = "" + GameController.gameScore;
    }
}
