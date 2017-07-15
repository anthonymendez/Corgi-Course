using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float jumpPower;

    public bool isGround;
    Rigidbody2D physicsBody;

	// Use this for initialization
	void Start () {
        physicsBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        bool jumpButton = Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space);
        if (isGround && jumpButton) {
            physicsBody.AddForce(Vector3.up * jumpPower * physicsBody.gravityScale * 100f);
        }
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
