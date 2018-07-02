using UnityEngine;
using System.Collections;

public class introPlay : MonoBehaviour {

	void OnMouseDown()
	{
		PlayerPrefs.SetInt("introAlreadyPlayed", 0);
		Application.LoadLevel("intro");
	}
}
