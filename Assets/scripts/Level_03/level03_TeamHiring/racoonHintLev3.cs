using UnityEngine;
using System.Collections;

public class racoonHintLev3 : MonoBehaviour {

	GameObject hintTeamHiringLevel03;
	// Use this for initialization
	void Start () 
	{
		hintTeamHiringLevel03 = GameObject.Find ("hintTeamHiringLevel03");
	}
	

	void OnMouseDown()
	{
		hintTeamHiringLevel03.renderer.enabled = true;
		hintTeamHiringLevel03.collider2D.enabled = true;
	}
}
