using UnityEngine;
using System.Collections;

public class endResResresh : MonoBehaviour {

	string currentLevelName;

	void Start () 
	{
		currentLevelName = Application.loadedLevelName;	
	}

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale = 1;
		Application.LoadLevel(currentLevelName);
	}
}
