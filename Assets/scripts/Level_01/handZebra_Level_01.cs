﻿using UnityEngine;
using System.Collections;

public class handZebra_Level_01 : MonoBehaviour {

	Animator anim;
	
	void Start ()
	{ 
		anim = this.GetComponent<Animator>();
	}	
	
	public void handBacktoShelf () 
	{
		anim.SetBool("zebraBack", true);
		renderer.enabled = true;
	}
}
