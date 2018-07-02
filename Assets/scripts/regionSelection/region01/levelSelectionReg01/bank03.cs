using UnityEngine;
using System.Collections;

public class bank03 : MonoBehaviour {

	GameObject bankLocked_03;
	
	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_03 = GameObject.Find ("bankLocked_03");
		if (!bankLocked_03)
		{
			PlayerPrefs.SetString("chaPos1", "");
			PlayerPrefs.SetString("chaPos2", "");
			PlayerPrefs.SetString("chaPos3", "");
			PlayerPrefs.SetString("chaPos4", "");

			Application.LoadLevel("teamHiringLev03");
		}
	}
}
