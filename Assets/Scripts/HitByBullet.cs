using UnityEngine;
using System.Collections;

public class HitByBullet : MonoBehaviour {

  ShipInfo myShipInfo;

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
      Destroy(gameObject);
    }

    if(other.gameObject.tag != "Player") {
      Destroy(other.gameObject);
    } 
    
  }

}
