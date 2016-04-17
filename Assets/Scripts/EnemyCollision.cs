using UnityEngine;
using System.Collections;

public class EnemyCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.tag == "Player") {
      bool damageApplied = FindObjectOfType<PlayerHealth>().TakeDamage(20);
      if (damageApplied) {
        GetComponent<Explosions>().Explode();
        Destroy(gameObject);
      }
    }
  }

}
