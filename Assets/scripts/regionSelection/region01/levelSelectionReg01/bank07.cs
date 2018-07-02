using UnityEngine;
using System.Collections;

public class bank07 : MonoBehaviour {

	GameObject bankLocked_07;

	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_07 = GameObject.Find ("bankLocked_07");
		if (!bankLocked_07)
		{
			PlayerPrefs.SetString("chaPos1", "");
			PlayerPrefs.SetString("chaPos2", "");
			PlayerPrefs.SetString("chaPos3", "");
			PlayerPrefs.SetString("chaPos4", "");

			Application.LoadLevel("L7_preview");
		}
	}
}
