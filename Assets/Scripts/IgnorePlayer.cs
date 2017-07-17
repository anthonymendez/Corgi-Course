using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlayer : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        Collider2D playerCollider = GameObject.FindWithTag("Player").GetComponent<Collider2D>();
        Collider2D thisCollider = GetComponent<EdgeCollider2D>();
        Physics2D.IgnoreCollision(playerCollider,thisCollider);
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")){

        }
    }
}
