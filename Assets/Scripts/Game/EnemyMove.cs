using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	Vector2 v = new Vector2 (0, -3);
	public float timer;

	// Use this for initialization
	void Start () {
		Invoke ("KillMe", time: timer);
	}
	// it will kill me
	void KillMe()
	{
		Destroy (this.gameObject);
	}

	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		var player = GameObject.FindGameObjectWithTag ("Player");

		// Position of the player
		Vector2 Mpos = player.transform.position;

		// Turn ship towards player
		Vector2 Tpos = transform.position;
		Vector2 diff = Mpos - Tpos;
		float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(10f, 10f, rot_z + 90);

		// Move ship forward
		GetComponent<Rigidbody2D> ().velocity = this.transform.rotation * v;
	}
}
