using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit_End : MonoBehaviour {

	//makes the button appear when the text fall off
	  public void OnCollisionEnter(Collision collision)
    {
        var script = FindObjectOfType<Credit_button>();

        script.ShowButtons();
    }
}
