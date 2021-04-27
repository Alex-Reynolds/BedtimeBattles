using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  public int maxHealth = 100;
  public int currentHealth = 0;

  public HealthBar healthBar;
    public GameObject Button;

  void Start() {
      currentHealth = maxHealth;
      Button.SetActive(false);
      healthBar.SetMaxHealth(maxHealth);
  }

  // Update is called once per frame
  void Update() {
    if (currentHealth <= 0) {
            Button.SetActive(true);
            gameObject.SetActive(false);
    }
  }

  void TakeDamage(int damage) {
    currentHealth -= damage;
    healthBar.SetHealth(currentHealth);
  }
  void OnCollisionEnter2D(Collision2D col) {
    if (col.gameObject.tag == "Enemy") {
      TakeDamage(10);
    }else if(col.collider.name == "BrainEnemy1" ||
            col.collider.name == "BrainEnemy2")
    {
            TakeDamage(2);
    }else if(col.gameObject.tag == "Finish")
        {
            TakeDamage(currentHealth);
        }
  }

}
