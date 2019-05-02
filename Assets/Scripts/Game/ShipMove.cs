using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour {
	// create the vector
	Vector2 s = new Vector2(0, -5);

	void Update ()
	{
		//left key make mouve left
		if (Input.GetKey("left")) {
			transform.Rotate(0, 0, 1f);
		}
		//right key make move right
		if (Input.GetKey("right")) {
			transform.Rotate(0, 0, -1f);
		}
	}

	void FixedUpdate()
	{
		// transform the rotation with the rigid body
		GetComponent<Rigidbody2D> ().velocity = this.transform.rotation * s;
	}
}
