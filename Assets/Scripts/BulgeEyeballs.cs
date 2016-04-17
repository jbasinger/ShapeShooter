using UnityEngine;
using System.Collections;

public class BulgeEyeballs : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    transform.localScale = new Vector3(Mathf.PingPong(Time.time, 0.25f) + 1, 1, 1);
	}
}
