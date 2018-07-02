using UnityEngine;
using System.Collections;

public class racoonHintLev7 : MonoBehaviour {

	GameObject hintTeamHiringLevel07;
	// Use this for initialization
	void Start () 
	{
		hintTeamHiringLevel07 = GameObject.Find ("hintTeamHiringLevel07");
	}
	
	
	void OnMouseDown()
	{
		hintTeamHiringLevel07.renderer.enabled = true;
		hintTeamHiringLevel07.collider2D.enabled = true;
	}
}
