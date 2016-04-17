using UnityEngine;
using System.Collections;

public class ColorFlipOut : MonoBehaviour {
  
	float timer;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    
		if(timer > 0){
			gameObject.GetComponent<SpriteRenderer>().color = new Color(Random.value,Random.value,Random.value);
		} else {
      gameObject.GetComponent<SpriteRenderer>().color = Color.white;
    }
    
    timer -= Time.deltaTime;

  }

  public void FlipOut(float duration) {
    timer = duration;
  }
}
