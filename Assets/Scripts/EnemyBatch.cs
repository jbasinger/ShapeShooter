using UnityEngine;
using System.Collections;

public class EnemyBatch : MonoBehaviour {

  public int batchSize;
  public float timeBetweenEnemies;
  public string pathName;
  public GameObject enemyPrefab;
  public float pathSpeed;

  //Firing style TBD

  int enemyCount = 0;

	// Use this for initialization
	void Start () {
    InvokeRepeating("ReleaseTheHounds", 0, timeBetweenEnemies);
	}
	
  void ReleaseTheHounds() {
    if(enemyCount == batchSize) {
      Destroy(gameObject);
      return;
    }

    Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0.1f, 0.9f), 1.25f, 0));
    pos.z = 0;

    GameObject enemy = Instantiate(enemyPrefab, pos, Quaternion.identity) as GameObject;
    
    iTween.MoveTo(enemy, iTween.Hash("path", iTweenPath.GetPath(pathName), 
      "time", pathSpeed, 
      "easetype", "linear"
      ));
    enemyCount++;

    Destroy(enemy, pathSpeed + 1);

  }
  
}
