using UnityEngine;
using System.Collections;

public class bank05 : MonoBehaviour {

	GameObject bankLocked_05;

	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_05 = GameObject.Find ("bankLocked_05");
		if (!bankLocked_05)
		{
			PlayerPrefs.SetString("chaPos1", "");
			PlayerPrefs.SetString("chaPos2", "");
			PlayerPrefs.SetString("chaPos3", "");
			PlayerPrefs.SetString("chaPos4", "");

			Application.LoadLevel("teamHiringLev05");
		}
	}
}
