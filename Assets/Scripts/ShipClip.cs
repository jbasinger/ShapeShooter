using UnityEngine;
using System.Collections;

public class ShipClip : MonoBehaviour {

  Vector3 playerSize;
  Rigidbody2D body;
  
  void Start () {
    playerSize = GetComponent<SpriteRenderer>().bounds.size;
    body = GetComponent<Rigidbody2D>();
	}
	
	void LateUpdate () {
    
    float left = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + (playerSize.x / 2);
    float right = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - (playerSize.x / 2);

    //We only want to let them get to 85% of the screen at the top
    float top = Camera.main.ViewportToWorldPoint(new Vector3(0, 0.85f, 0)).y;
    float bottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + (playerSize.y / 2);
    
    body.position = (new Vector3(
        Mathf.Clamp(body.position.x, left, right),
        Mathf.Clamp(body.position.y, bottom, top),
        0)
    );

  }
}
