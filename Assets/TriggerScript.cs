﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        print(">>>");
        Example2Player player = other.GetComponent<Example2Player>();
        if (player != null)
        {
            player.TakeDamage();
        }
    }
}
