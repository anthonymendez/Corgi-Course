using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {

    public float moveSpeed;

    public SpriteRenderer thisR, rightSR, leftSR;

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.left * moveSpeed / 100f * Time.timeScale);

        if (transform.position.x <= -5.79) {
            thisR.sortingOrder = 2;
            leftSR.sortingOrder = 1;
            rightSR.sortingOrder = 0;
            transform.position = new Vector3(transform.position.x+(3*4.06f), transform.position.y, transform.position.z);
        }
    }
}
