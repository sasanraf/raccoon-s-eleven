﻿using UnityEngine;
using System.Collections;

public class handMonkey_Level_01 : MonoBehaviour {

	Animator anim;

	void Start ()
	{ 
		anim = this.GetComponent<Animator>();
	}	

	public void handBacktoShelf () 
	{
		anim.SetBool("monkeyBack", true);
		renderer.enabled = true;
	}

}
