using UnityEngine;
using System.Collections;

public class region01 : MonoBehaviour {

	void OnMouseDown () 
	{
		audio.Play();
		Application.LoadLevel("levelsSelect_Reg01");
	}
}
