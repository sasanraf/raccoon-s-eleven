﻿using UnityEngine;
using System.Collections;

public class exitGame : MonoBehaviour 
{
	Animator anim;
	
	void Start ()
	{ 
		anim = this.GetComponent<Animator>();
		anim = this.GetComponent<Animator>();

	}	
	
	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.Quit();
	}
	
	public void moveExit(bool TorF)
	{
		anim.SetBool("moveExit", TorF);
		this.collider2D.enabled = TorF;
	}
}