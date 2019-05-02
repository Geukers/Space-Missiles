using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Credit_button : MonoBehaviour {
	//button exit
	private Button[] exit;

	//make invisible the button
	public void Awake()
	{
		exit = GetComponentsInChildren<Button>();

		DisableExit();
	}
	//to make it active 
	public void ToggleButtons(bool state)
	{
		foreach (var e in exit)
		{
			e.gameObject.SetActive(state);
		}

	}
	// if it is not toutch it will stay invisible
	public void DisableExit()
	{
		ToggleButtons(false);
	}
	// make it apper if the button is toggle
	public void ShowButtons()
	{
		ToggleButtons(true);
	}
	//send you to the main menu
	public void GoToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
