﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  public int maxHealth = 100;
  public int currentHealth = 0;

  public HealthBar healthBar;

  void Start() {
      currentHealth = maxHealth;
      healthBar.SetMaxHealth(maxHealth);
  }

  // Update is called once per frame
  //void Update() {
    //if (Input.GetKeyDown(KeyCode.Space)) {
    //  TakeDamage(20);
    //}
  //}

  void TakeDamage(int damage) {
    currentHealth -= damage;
    healthBar.SetHealth(currentHealth);
  }
  void OnCollisionEnter2D(Collision2D col) {
    if (col.gameObject.tag == "Enemy") {
      TakeDamage(20);
    }
  }

}
