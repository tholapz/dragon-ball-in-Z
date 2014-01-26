using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		rigidbody.velocity = new Vector3(0.0f, 1.0f,1.0f) * speed;
	}

}
