﻿using UnityEngine;
using System.Collections;

public class balaScript : MonoBehaviour {

	public Vector2 velocity = new Vector2(5,0);
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = velocity * transform.localScale.x;

	}
}