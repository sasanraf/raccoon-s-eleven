using UnityEngine;
using System.Collections;

public class bank09 : MonoBehaviour {

	GameObject bankLocked_09;

	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_09 = GameObject.Find ("bankLocked_09");
		if (!bankLocked_09)
		{
			PlayerPrefs.SetString("chaPos1", "");
			PlayerPrefs.SetString("chaPos2", "");
			PlayerPrefs.SetString("chaPos3", "");
			PlayerPrefs.SetString("chaPos4", "");

			Application.LoadLevel("L9_preview");
		}
	}
}
