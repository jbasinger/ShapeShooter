using UnityEngine;
using System.Collections;

public class DeathData : MonoBehaviour {

  public int Kills { get; set; }

  void Awake() {
    DontDestroyOnLoad(this);
  }

}
