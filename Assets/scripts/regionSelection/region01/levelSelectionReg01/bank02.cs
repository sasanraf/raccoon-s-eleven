using UnityEngine;
using System.Collections;

public class bank02 : MonoBehaviour {

	GameObject bankLocked_02;
	
	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_02 = GameObject.Find ("bankLocked_02");
		if (!bankLocked_02)
		{
			Application.LoadLevel("L2_final");
		}
	}
}
