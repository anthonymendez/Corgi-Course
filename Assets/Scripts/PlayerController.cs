using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float jumpPower;
    
    bool isGround;
    Rigidbody2D physicsBody;
    Animator playerAnimator;

	// Use this for initialization
	void Start () {
        physicsBody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        bool jumpButton = Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space);
        if (GameController.inGame && isGround && jumpButton) {
            physicsBody.AddForce(Vector3.up * jumpPower * physicsBody.gravityScale * 100f);
        }
        
        playerAnimator.SetBool("isGround", isGround);
        playerAnimator.SetBool("inGame", GameController.inGame);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isGround = true;
        }

        if (collision.gameObject.CompareTag("Enemy")) {
            GameController.isDead = true;
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
