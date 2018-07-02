using UnityEngine;
using System.Collections;

public class bank06 : MonoBehaviour {

	GameObject bankLocked_06;

	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_06 = GameObject.Find ("bankLocked_06");
		if (!bankLocked_06)
		{
			PlayerPrefs.SetString("chaPos1", "");
			PlayerPrefs.SetString("chaPos2", "");
			PlayerPrefs.SetString("chaPos3", "");
			PlayerPrefs.SetString("chaPos4", "");

			Application.LoadLevel("teamHiringLev06");
		}
	}
}
