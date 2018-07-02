using UnityEngine;
using System.Collections;

public class excellentClickEnd : MonoBehaviour 
{

	// Update is called once per frame
	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		this.audio.Play();
		PlayerPrefs.SetString("bankReg01_Bank02", "unlocked");
		Application.LoadLevel("L2_final");
		//Application.LoadLevel("L2_final");
	}
}
