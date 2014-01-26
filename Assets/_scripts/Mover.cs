using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		rigidbody.velocity = new Vector3(-1.0f,0.0f,0.0f) * speed;
	}

}
