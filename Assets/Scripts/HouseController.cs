using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseController : MonoBehaviour {

    public float moveSpeed;

    public Sprite[] houseTypes;

    SpriteRenderer thisSR;

    //Called when it is created
    void Start() {
        thisSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.left * moveSpeed / 100f * Time.timeScale);

        if (transform.localPosition.x <= -2f) {
            transform.localPosition = new Vector3(transform.localPosition.x + (4 * 1.0667f), transform.localPosition.y, transform.localPosition.z);
            thisSR.sprite = houseTypes[(int)Random.Range(0f, houseTypes.Length)];
        }
    }
}
