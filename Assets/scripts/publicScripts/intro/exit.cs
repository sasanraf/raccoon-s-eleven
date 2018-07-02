using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour {

	void OnMouseDown()
	{
		this.audio.Play();
		Application.LoadLevel("mainMenu");
	}
}
