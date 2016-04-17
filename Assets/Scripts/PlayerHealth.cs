using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

  public int maxHealth;
  public int currentHealth;
  public float invulnTimer = 1;

  public Image healthBar;
  public float fullPosition;
  public float emptyPosition;

  float timer;
  bool hit = false;

	// Use this for initialization
	void Start () {
    timer = 0;
    healthBar.rectTransform.localPosition = new Vector2(fullPosition, 0);
	}
	
	// Update is called once per frame
	void Update () {

    if(hit && timer <= 0) {
      hit = false;
    }

    timer -= Time.deltaTime;
	}

  public bool TakeDamage(int damage) {

    if (!hit) {
      
      currentHealth -= damage;
      UpdateHealthBar();

      if (currentHealth <= 0) {
        PlayerDie();
      }

      hit = true;
      timer = invulnTimer;

      return true;

    }

    return false;

  }

  void PlayerDie() {
    SceneManager.LoadScene("Main", LoadSceneMode.Single);
  }

  void UpdateHealthBar() {
    float percent = 1 - ((float)currentHealth / (float)maxHealth);
    Debug.Log("Precent: " + percent.ToString());
    healthBar.rectTransform.localPosition = new Vector2(emptyPosition*percent, 0);
  }

}
