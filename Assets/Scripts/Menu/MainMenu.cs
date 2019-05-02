using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    /// <summary>
    /// Runs Menu
    /// </summary>
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");//start game
    }
	public void Credits()
	{
		SceneManager.LoadScene("Scene_2");// start credit
	}
    public void Exit()
    {
        Application.Quit(); // quit the game
    }
}
