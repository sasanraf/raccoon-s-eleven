﻿using UnityEngine;
using System.Collections;

public class page02 : MonoBehaviour {

	Animator anim;
	
	// Use this for initialization
	void Start () 
	{
		
		anim = this.GetComponent<Animator>();
		
	}
	public void move()
	{
		anim.SetBool("move", true);
	}


}
