using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static bool inGame;

	// Use this for initialization
	void Start () {
        inGame = true;
	}
	
	// Update is called once per frame
	void Update () {

        if (inGame) {
            Time.timeScale = 1;
        } else {
            Time.timeScale = 0;
        }

	}
}
