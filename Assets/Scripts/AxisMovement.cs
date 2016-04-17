using UnityEngine;
using System.Collections;

public class AxisMovement : MonoBehaviour {

  public float speed = 10;

  Rigidbody2D body;

	// Use this for initialization
	void Start () {
    body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

    float x = Input.GetAxis("Horizontal");// * speed;
    float y = Input.GetAxis("Vertical");// * speed;

    body.velocity = new Vector3(x, y) * speed;

    //this.transform.Translate(x*Time.deltaTime, y*Time.deltaTime, 0);

	}
}
