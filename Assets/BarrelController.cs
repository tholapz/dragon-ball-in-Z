﻿using UnityEngine;
using System.Collections;

public class BarrelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround(Vector3.zero, Vector3.forward, 20 * Time.deltaTime);
	}
}
