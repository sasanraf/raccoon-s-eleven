using UnityEngine;
using System.Collections;

public class bank01 : MonoBehaviour {

	GameObject bankLocked_01;

	void OnMouseDown  () 
	{
		audio.Play ();
		Time.timeScale=1;
		bankLocked_01 = GameObject.Find ("bankLocked_01");
		if (!bankLocked_01)
		{
			Application.LoadLevel("L1_final");
		}
	}
}
