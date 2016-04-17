using UnityEngine;
using System.Collections.Generic;

public class EnemyGenerator : MonoBehaviour {

  public float generateTime;

  public EnemyBatch enemyBatch;

  public GameObject[] enemyPrefabs;
  public string[] pathNames;
  public int minBatchSize;
  public int maxBatchSize;
  public float minTimeBetweenEnemiesInBatch;
  public float maxTimeBetweenEnemiesInBatch;
  public float minPathSpeed;
  public float maxPathSpeed;
  public int minConcurrentBatches;
  public int maxConcurrentBatches;

  //public GameObject[] movementStyles;
  //public GameObject[] firingStyles;

  float timer;

	// Use this for initialization
	void Start () {
    timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
	  
    if(timer <= 0) {
      timer = generateTime;
      
      int batchs = Random.Range(minConcurrentBatches, maxConcurrentBatches);
      List<string> usedPathNames = new List<string>();

      for(int i=0; i < batchs; i++) {
        EnemyBatch batch = Instantiate(enemyBatch) as EnemyBatch;
        batch.batchSize = Random.Range(minBatchSize, maxBatchSize);
        batch.timeBetweenEnemies = Random.Range(minTimeBetweenEnemiesInBatch, maxTimeBetweenEnemiesInBatch);
        batch.pathName = pathNames[Random.Range(0, pathNames.Length)];
        batch.enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        batch.pathSpeed = Random.Range(minPathSpeed, maxPathSpeed);
      }
      
    }

    timer -= Time.deltaTime;

	}

}
