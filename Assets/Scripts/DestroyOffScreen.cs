using UnityEngine;
using System.Collections;

public class DestroyOffScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);

    if(pos.y <= -0.1) {
      Destroy(gameObject);
    }

    //if(pos.x >= 1.1 || pos.x <= -.1 || pos.y <= -.1 || pos.y > 1.1){
      
    //}
	}
}
