using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision)
	{
		//if it gets in a collision with the player it will restart the game
		if (collision.gameObject.tag=="Player")
		 {
            RestartGame();
		}
	}
	// it will restart the game
    void RestartGame()
	{
		//reload the game
		SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        Score.Remain = 7;
	}
}
