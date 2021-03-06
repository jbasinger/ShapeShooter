﻿using UnityEngine;
using System.Collections;

public class HitByBullet : MonoBehaviour {

  ShipInfo myShipInfo;

  public AudioClip[] explosions;

	// Use this for initialization
	void Start () {
    myShipInfo = GetComponent<ShipInfo>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnCollisionEnter2D(Collision2D other) {
    ShipInfo otherInfo = other.gameObject.GetComponent<ShipInfo>();
    if (otherInfo != null && myShipInfo.type == otherInfo.type) {
      GetComponent<Explosions>().Explode();
      AudioSource.PlayClipAtPoint(explosions[Random.Range(0, explosions.Length)], transform.position);
      Destroy(gameObject);
      PlayerScore score = FindObjectOfType<PlayerScore>() as PlayerScore;
      score.AnotherOneBitesTheDust(1);
    }

    if(other.gameObject.tag != "Player") {
      Destroy(other.gameObject);
    } 
    
  }

}
