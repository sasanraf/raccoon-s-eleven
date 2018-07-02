using UnityEngine;
using System.Collections;

public class backToMainPage : MonoBehaviour {

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.LoadLevel("mainMenu");
	}
}
