using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlayer : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        /*Collider2D playerCollider = GameObject.FindWithTag("Player").GetComponent<Collider2D>();
        Collider2D thisCollider = GetComponent<EdgeCollider2D>();
        Physics2D.IgnoreCollision(playerCollider,thisCollider);*/
	}

    void Update() {
        transform.Translate(Vector3.left * 6f / 100f * Time.timeScale);
    }
}
