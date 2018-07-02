﻿using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour 
{
	Animator anim;
	
	void Start ()
	{ 
		anim = this.GetComponent<Animator>();
	}	
	
	void OnMouseDown  () 
	{
		this.audio.Play();
		Time.timeScale=1;
		Application.LoadLevel("mainMenu");
	}
	
	public void moveMainMenu(bool TorF)
	{
		anim.SetBool("moveMainMenu", TorF);
		this.collider2D.enabled = TorF;
	}
}
