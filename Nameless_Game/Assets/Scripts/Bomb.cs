﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {
	GameObject player;
	Rigidbody rb;
	public float speed=500f;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		rb = GetComponent<Rigidbody> ();
		Vector3 vec = player.transform.position - transform.position;
		transform.rotation = Quaternion.LookRotation (vec);
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = transform.forward * Time.deltaTime * speed;
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("N")
		   || other.gameObject.CompareTag ("S")
		   || other.gameObject.CompareTag ("W")
		   || other.gameObject.CompareTag ("E")) {
			Destroy (gameObject);
		}
	}
}
