using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    public static bool inGame;
    public static bool isDead;
    public static bool isPaused;
    public static float currentTime;
    public static int gameScore;

    public GameObject player;
    public GameObject enemyGroup;
    public GameObject enemySpawner;
    public GameObjectPool enemyPool;
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject pauseIcon;
    public GameObject deadMenu;
    public GameObject scoreUI;

    // Use this for initialization
    void Start () {
        inGame = false;
        isDead = false;
        enemySpawner.SetActive(false);
        pauseIcon.SetActive(false);
        gameScore = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (isDead) {
            Time.timeScale = 0;
            deadMenu.SetActive(true);
            pauseIcon.SetActive(false);
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

    public void Restart() {
        player.transform.position = new Vector2(-1.59f, -1.78f);
        foreach (Transform child in enemyGroup.transform) {
            GameObject.Destroy(child.gameObject);
        }
        inGame = true;
        isDead = false;
        gameScore = 0;
        deadMenu.SetActive(false);
        scoreUI.SetActive(true);
        inGame = true;
    }

    public void MainMenu() {
        isPaused = false;
        inGame = false;
        isDead = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
