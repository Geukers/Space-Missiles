using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRockets : MonoBehaviour {
	public GameObject rocket;
	public float Timer;
	float lastDrop = 0;
	
	// Update is called once per frame
	void Update () {
		//Spawn new rocket with the time
		if (Time.time - lastDrop >= Timer)
		{

			Instantiate(rocket, transform.position, Quaternion.identity);
			lastDrop = Time.time;
		}
	}
}
