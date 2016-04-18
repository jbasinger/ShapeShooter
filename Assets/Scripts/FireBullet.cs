using UnityEngine;
using System.Collections;

public class FireBullet : MonoBehaviour {

  public AudioClip laserSound;

  public float cooldown;
  public GameObject bullet;
  public Transform turret;
  
  float timer = 0;

  // Use this for initialization
  void Start() {
  }
	
	// Update is called once per frame
	void Update () {

    if (/*Input.GetKey("space") &&*/ timer <= 0) {
      timer = cooldown;
      Instantiate(bullet, turret.position, Quaternion.identity);
      if(laserSound != null) {
        AudioSource.PlayClipAtPoint(laserSound, transform.position);
      }
    }

    timer -= Time.deltaTime;

	}
}
