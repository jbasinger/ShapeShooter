using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour {

  public Text scoreBoard;

  int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  public void AnotherOneBitesTheDust(int points) {
    score += points;
    scoreBoard.text = score.ToString();
  }

}
