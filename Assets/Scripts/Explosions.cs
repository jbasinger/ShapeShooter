using UnityEngine;
using System.Collections;

public class Explosions : MonoBehaviour {

  public GameObject explosionPrefab;

	// Use this for initialization
	void Start () {
	}
  
  public void Explode() {
    GameObject explosion = Instantiate(explosionPrefab) as GameObject;
    explosion.transform.position = transform.position;
    Destroy(explosion, 0.5f);
  }

}
