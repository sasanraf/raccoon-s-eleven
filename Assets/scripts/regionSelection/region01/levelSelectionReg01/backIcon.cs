using UnityEngine;
using System.Collections;

public class backIcon: MonoBehaviour {

	void OnMouseDown  () 
	{
		audio.Play ();
		Application.LoadLevel("regionSelection");
	}
}
