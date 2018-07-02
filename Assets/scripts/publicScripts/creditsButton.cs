using UnityEngine;
using System.Collections;

public class creditsButton : MonoBehaviour {

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.LoadLevel("creditsPage");
	}
}
