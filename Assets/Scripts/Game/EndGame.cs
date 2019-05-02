using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {
	// button display
    public GameObject can;

    public void OnCollisionEnter2D(Collision2D col)
    {
		// if collision to an enemy 'rockets' it will restart the scene
        if(col.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
            Score.Remain = 7;
            
        }
    }

	//make the buttons invisible
    public void Start ()
    {
        can.SetActive(false);
    }

    // Update is called once per frame
    void Update ()
    {
		// if the score is 0
		if(Score.Remain == 0)
        {
			// make appear the buttons
            can.SetActive(true);
        }

		// if you press tje escape buttons it will make appear the buttons
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            can.SetActive(true);
			
        }
	}
}
