using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public float timeDelayBetweenEnemySpawning;
    public GameObjectPool enemyPool;
    public Transform enemyGroup;

    float currentTimeDelayBetweenEnemySpawning;

	// Use this for initialization
	void Start () {
        currentTimeDelayBetweenEnemySpawning = 0;
        enemyGroup = GameObject.FindWithTag("ActiveEnemy").transform;
    }
	
	// Update is called once per frame
	void Update () {
        currentTimeDelayBetweenEnemySpawning += Time.deltaTime;

        if (currentTimeDelayBetweenEnemySpawning >= timeDelayBetweenEnemySpawning) {
            currentTimeDelayBetweenEnemySpawning = 0;
            GameObject newEnemy = enemyPool.GetGameObject();
            newEnemy.transform.parent = enemyGroup;
            newEnemy.transform.position = transform.position;
        }
	}
}
