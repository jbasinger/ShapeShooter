using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    if (Input.GetKeyUp("p")) {
      Time.timeScale = Time.timeScale == 0 ? 1 : 0;
    }

	}
}
