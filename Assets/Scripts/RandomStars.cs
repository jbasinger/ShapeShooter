using UnityEngine;
using System.Collections;

public class RandomStars : MonoBehaviour {

  public GameObject starPrefab;

  float tick = 1f;
  float timer;

	// Use this for initialization
	void Start () {
    timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
	  
    if(timer <= 0) {
      timer = tick;
      int batch = Random.Range(5, 10);
      for(int i=0;i< batch; i++) {
        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0f, 1f), Random.Range(1f, 1.1f)));
        pos.z = 0;
        
        GameObject star = Instantiate(starPrefab, pos, Quaternion.identity) as GameObject;

        star.transform.SetParent(gameObject.transform);

        star.transform.position = pos;

        Rigidbody2D starBody = star.GetComponent<Rigidbody2D>();
        //starBody.gravityScale = Random.Range(0.1f, 1f);
        starBody.velocity = new Vector2(0, -1*Random.Range(3f, 10f));
      }
    }

    timer -= Time.deltaTime;

	}
}
