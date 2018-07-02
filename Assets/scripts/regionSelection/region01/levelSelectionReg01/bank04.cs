using UnityEngine;
using System.Collections;

public class bank04 : MonoBehaviour {

	GameObject bankLocked_04;

	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_04 = GameObject.Find ("bankLocked_04");
		if (!bankLocked_04)
		{
			PlayerPrefs.SetString("chaPos1", "");
			PlayerPrefs.SetString("chaPos2", "");
			PlayerPrefs.SetString("chaPos3", "");
			PlayerPrefs.SetString("chaPos4", "");

			Application.LoadLevel("teamHiringLev04");
		}
	}
}
