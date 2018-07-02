using UnityEngine;
using System.Collections;

public class bank08 : MonoBehaviour {

	GameObject bankLocked_08;

	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_08 = GameObject.Find ("bankLocked_08");
		if (!bankLocked_08)
		{
			PlayerPrefs.SetString("chaPos1", "");
			PlayerPrefs.SetString("chaPos2", "");
			PlayerPrefs.SetString("chaPos3", "");
			PlayerPrefs.SetString("chaPos4", "");

			Application.LoadLevel("L8_preview");
		}
	}
}
