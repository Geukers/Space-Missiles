using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene1_Scripts : MonoBehaviour {
	//create buttons
    private Button[] buttons;
    public GameObject canvas;

	//Use the button
	//it makes the button "Exit" disapear before the game
    public void Awake()
    {
        buttons = GetComponentsInChildren<Button>();

        DisableButtons();
    }

	// activate the button to appear
    public void ToggleButtons(bool state)
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(state);
        }

    }
	//make the button invisible until it gets activate
    public void DisableButtons()
    {
        ToggleButtons(false);
    }
    // make the button apear
    public void ShowButtons()
    {
        ToggleButtons(true);
    }
	//send you to the game 'restart'
    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlay");
        canvas.SetActive(false);
        Score.Remain = 7; // initialize the score otherwise it goes negative 
	}
	//send you to the menu
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Score.Remain = 7; // initialize the score otherwise it goes negative 
    }
}
