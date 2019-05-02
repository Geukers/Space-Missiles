using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour {
	//initialize the points value
    public int pointValue = -1;
	//create the sound
	private AudioSource source;


	void Start() {
		//make the sound work
		source = gameObject.GetComponent<AudioSource>();
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		// if the space ship hits a coin
        if (col.gameObject.tag == "Coin")
        {
			//will play the sound if
			source.Play();
			// minus the score 
            Score.Remain += pointValue;
			//destroy the coin
            Destroy(col.gameObject);		
        }
	}
	
}