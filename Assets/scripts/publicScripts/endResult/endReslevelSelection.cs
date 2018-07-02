using UnityEngine;
using System.Collections;

public class endReslevelSelection : MonoBehaviour {

	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale = 1;
		Application.LoadLevel("levelsSelect_Reg01");
	}
}
