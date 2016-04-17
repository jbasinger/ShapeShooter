using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowKillsOnDeath : MonoBehaviour {
  
  public Text scoreBoard;

	// Use this for initialization
	void Start () {

    DeathData data = FindObjectOfType<DeathData>();

    if(data != null) {
      scoreBoard.text = data.Kills.ToString();
    } else {
      scoreBoard.text = (0).ToString();
    }

	}

}
