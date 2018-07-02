using UnityEngine;
using System.Collections;

public class exitTutorial : MonoBehaviour {

	void OnMouseDown  () 
	{
		this.audio.Play();
		Application.LoadLevel(PlayerPrefs.GetString("currentLevelNameTutorial"));
	}

}
