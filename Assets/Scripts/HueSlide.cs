using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HueSlide : MonoBehaviour {
  
  public Graphic graphic;

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
    graphic.color = Color.HSVToRGB(Mathf.PingPong(Time.time/2, 1), 1, 1);
  }
}
