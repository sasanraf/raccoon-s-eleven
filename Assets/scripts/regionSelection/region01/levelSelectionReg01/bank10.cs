using UnityEngine;
using System.Collections;

public class bank10 : MonoBehaviour {

	GameObject bankLocked_10;

	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_10 = GameObject.Find ("bankLocked_10");
		if (!bankLocked_10)
		{
			PlayerPrefs.SetString("chaPos1", "");
			PlayerPrefs.SetString("chaPos2", "");
			PlayerPrefs.SetString("chaPos3", "");
			PlayerPrefs.SetString("chaPos4", "");

			Application.LoadLevel("L10_preview");
		}
	}
}
