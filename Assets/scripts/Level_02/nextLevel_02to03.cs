using UnityEngine;
using System.Collections;

public class nextLevel_02to03 : MonoBehaviour {

	void OnMouseDown  () 
	{
		Time.timeScale=1;
		PlayerPrefs.SetString("chaPos1", "");
		PlayerPrefs.SetString("chaPos2", "");
		PlayerPrefs.SetString("chaPos3", "");
		PlayerPrefs.SetString("chaPos4", "");
		Application.LoadLevel("teamHiringLev03");
	}
}
