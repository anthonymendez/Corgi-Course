using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static bool inGame;
    public static bool isDead;
    public static bool isPaused;
    public static float currentTime;

    public GameObject enemySpawner;
    public GameObject pauseMenu;
    public GameObject pauseIcon;

    // Use this for initialization
    void Start () {
        inGame = false;
        isDead = false;
        enemySpawner.SetActive(false);
        pauseIcon.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

        if (isDead) {
            inGame = false;
            Time.timeScale = 0;
        } else if (inGame && !isPaused) {
            Time.timeScale = 1;
            enemySpawner.SetActive(true);
            pauseIcon.SetActive(true);
            currentTime += Time.deltaTime;
        } else if (inGame && isPaused) {
            Time.timeScale = 0;
            pauseIcon.SetActive(false);
        } else if (!inGame) {
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

    public void TogglePause() {
        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);
        pauseIcon.SetActive(!isPaused);
    }
}
