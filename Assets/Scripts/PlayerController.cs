﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Damage = 10;
    public float Health = 100;
    public float AttackSpeed = 5;
    public float Deffense = 0; //percent

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(float damage)
    {
        this.Health -= damage;
    }
}
