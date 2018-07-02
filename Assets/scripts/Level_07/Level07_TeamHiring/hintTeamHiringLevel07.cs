using UnityEngine;
using System.Collections;

public class hintTeamHiringLevel07 : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		if (PlayerPrefs.GetInt("hintTeamHiringLevel07") == 1)
		{
			this.renderer.enabled = false;
			this.collider2D.enabled = false;
		}
		else
		{
			this.renderer.enabled = true;
			PlayerPrefs.SetInt("hintTeamHiringLevel07",1);
		}
	}
	
	void OnMouseDown()
	{
		this.renderer.enabled = false;
		this.collider2D.enabled = false;
	}
}
