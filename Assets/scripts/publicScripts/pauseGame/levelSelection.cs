﻿using UnityEngine;
using System.Collections;


public class levelSelection : MonoBehaviour 
{
	Animator anim;
	
	void Start ()
	{ 
		anim = this.GetComponent<Animator>();
	}	
	
	void OnMouseDown  () 
	{
		Time.timeScale=1;
		Application.LoadLevel("levelsSelect_Reg01");
	}
	
	public void movelevelSelection(bool TorF)
	{
		anim.SetBool("movelevelSelection", TorF);
		this.collider2D.enabled = TorF;
	}
	
}
