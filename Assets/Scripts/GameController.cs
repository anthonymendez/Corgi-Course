using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static bool inGame;
    public static bool isDead;

    public GameObject enemySpawner;

    // Use this for initialization
    void Start () {
        inGame = false;
        isDead = false;
        enemySpawner.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (isDead) {
            inGame = false;
        }

        if (inGame) {
            Time.timeScale = 1;
            enemySpawner.SetActive(true);
        } else {
            Time.timeScale = 0;
            enemySpawner.SetActive(false);
        }

	}

    public void Play() {
        inGame = true;
    }

    public void ExitGame() {
        inGame = false;
    }
}
