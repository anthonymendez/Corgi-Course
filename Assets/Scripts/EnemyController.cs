using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float jumpPower;
    public float delayBetweenJumps;
    public float moveSpeed;

    public GameObjectPool enemyPool;

    bool isGround;
    bool passedPlayer, scoreGiven;
    Rigidbody2D physicsBody;
    float currentDelayBetweenJumps;
    Animator enemyAnimator;
    Transform temp;
    AudioSource jumpCompletedAudio;

    // Use this for initialization
    void Start() {
        jumpCompletedAudio = GetComponent<AudioSource>();
        physicsBody = GetComponent<Rigidbody2D>();
        currentDelayBetweenJumps = 0;
        enemyAnimator = GetComponent<Animator>();
        enemyPool = GameObject.FindWithTag("EnemyPool").GetComponent<GameObjectPool>();
    }

    // Update is called once per frame
    void Update() {
        currentDelayBetweenJumps += Time.deltaTime;

        if (isGround && delayBetweenJumps <= currentDelayBetweenJumps) {
            physicsBody.AddForce(Vector3.up * jumpPower * physicsBody.gravityScale * 100f);
            currentDelayBetweenJumps = 0;
        }

        if (transform.position.x > -1.3f) {
            passedPlayer = false;
            scoreGiven = false;
        } else {
            passedPlayer = true;
        }

        if (passedPlayer && !scoreGiven) {
            GameController.gameScore++;
            scoreGiven = true;
            jumpCompletedAudio.Play();
        }

        transform.Translate(Vector3.left * moveSpeed / 100f * Time.timeScale);

        if (transform.position.x <= -8f) {
            enemyPool.AddGameObject(gameObject);
        }

        if (GameController.isPaused) {
            enemyAnimator.updateMode = AnimatorUpdateMode.Normal;
        } else {
            enemyAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
        }

        enemyAnimator.SetBool("isGround",isGround);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isGround = true;
        }
    }

    void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isGround = false;
        }
    }
}
