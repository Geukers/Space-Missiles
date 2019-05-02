using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	//set the score at 7
	public static int Remain = 7;

	public void OnGUI()
	{

		GUI.Label(new Rect(20, 200, 200, 50), "REMAINING :"); //Text
		GUI.Label(new Rect(20, 220, 200, 50), Remain.ToString()); // Put the score
}
}
