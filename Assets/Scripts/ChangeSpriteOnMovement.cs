using UnityEngine;
using System.Collections;

public class ChangeSpriteOnMovement : MonoBehaviour {

  public Sprite changeSprite;
  public Sprite origSprite;

  SpriteRenderer render;

	// Use this for initialization
	void Start () {
    render = GetComponent<SpriteRenderer>();
	}

  void FixedUpdate() {

    float x = Input.GetAxis("Horizontal");// * speed;

    render.flipX = false;

    if(x < 0) {
      render.flipX = true;
      render.sprite = changeSprite;
    } else if (x == 0) {
      render.sprite = origSprite;
    } else {
      render.sprite = changeSprite;
    }

  }
}
