using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
  
  public float speed;
  Rigidbody2D body;


  // Use this for initialization
  void Start () {
    body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

    body.velocity = new Vector2(0, speed);

    if(Camera.main.WorldToViewportPoint(transform.position).y > 1.10f) {
      Destroy(gameObject);
    }
	}
}
