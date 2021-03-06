﻿using UnityEngine;
using System.Collections;

public class zebra_Level_02 : MonoBehaviour {

	//mouse and screen-
	private Vector3 screenPoint;
	private float mouseX;
	private float mouseY;
	private Vector3 mouseposition;
	
	//highlights monkey
	private GameObject highlightMonMeercat01;
	private GameObject highlightMonMeercat02;
	private GameObject highlightMonMeercat03;
	private GameObject highlightMonTeller01;
	private GameObject highlightMonTeller03;
	
	//highlight zebra
	private GameObject 	highlightZebMeercat01;
	private GameObject 	highlightZebMeercat02;
	private GameObject 	highlightZebMeercat03;
	private GameObject 	highlightZebTeller01;
	private GameObject 	highlightZebTeller03;
	
	private GameObject zebraDummy;

	private GameObject moneyTeller01;
	private GameObject moneyTeller03;
	
	private GameObject timerObjectZebra;

	public bool zebraIsInside = false;

	//accessing monkey timer script
	timerMonkey_Level_02 timerMonkey;
	private GameObject monkey;

	public AudioSource drag;
	public AudioSource moneyDone;

	//accessing zebra timer script
	timerZebra_Level_02 timerZebra;
	
	Animator anim;
	

	void Start ()
	{ 
		AudioSource[] audios = GetComponents<AudioSource>();
		drag = audios[0];
		moneyDone = audios[1];

		timerObjectZebra = GameObject.Find ("timerObjectZebra");
		timerZebra = GameObject.Find ("timerObjectZebra").GetComponent<timerZebra_Level_02>();
		monkey = GameObject.Find ("monkey"); 
		timerMonkey = GameObject.Find ("timerObjectMonkey").GetComponent<timerMonkey_Level_02>();

		highlightMonMeercat01 = GameObject.Find ("highlightMonMeercat01");
		highlightMonMeercat02 = GameObject.Find ("highlightMonMeercat02");
		highlightMonMeercat03 = GameObject.Find ("highlightMonMeercat03");
		highlightMonTeller01 = GameObject.Find ("highlightMonTeller01");
		highlightMonTeller03 = GameObject.Find ("highlightMonTeller03");
		
		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		highlightZebMeercat02 = GameObject.Find ("highlightZebMeercat02");
		highlightZebMeercat03 = GameObject.Find ("highlightZebMeercat03");
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");
		
		zebraDummy = GameObject.Find ("zebraDummy");

		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller03 = GameObject.Find ("moneyTeller03");
		
		anim = this.GetComponent<Animator>();
	}	
	
	void OnMouseOver()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
	
		
		if (highlightZebMeercat01 && timerMonkey.monkeyFinishedMeercat01 && transform.position != highlightZebMeercat01.transform.position && monkey.transform.position != highlightZebMeercat01.transform.position)
		{
			highlightZebMeercat01.renderer.enabled = true;
		}
		
		if (highlightZebMeercat02 && timerMonkey.monkeyFinishedMeercat02 && transform.position != highlightZebMeercat02.transform.position && monkey.transform.position != highlightZebMeercat02.transform.position)
		{
			highlightZebMeercat02.renderer.enabled = true;
		}
		
		if (highlightZebMeercat03 && timerMonkey.monkeyFinishedMeercat03 && transform.position != highlightZebMeercat03.transform.position && monkey.transform.position != highlightZebMeercat03.transform.position)
		{
			highlightZebMeercat03.renderer.enabled = true;
		}

		if (highlightZebTeller01 && timerMonkey.monkeyFinishedTeller01 && transform.position != highlightZebTeller01.transform.position && monkey.transform.position != highlightZebTeller01.transform.position)
		{
			highlightZebTeller01.renderer.enabled = true;
		}
		
		if (highlightZebTeller03 && timerMonkey.monkeyFinishedTeller03 && transform.position != highlightZebTeller03.transform.position && monkey.transform.position != highlightZebTeller03.transform.position)
		{
			highlightZebTeller03.renderer.enabled = true;
		}

	}
	
	void OnMouseDrag()  
	{		
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
		transform.position = currentPos;
	}
	
	void OnMouseUp () 
	{
		
		if (highlightZebMeercat01 && timerMonkey.monkeyFinishedMeercat01 && monkey.transform.position != highlightZebMeercat01.transform.position && transform.position.x < highlightZebMeercat01.transform.position.x+2f
		    && transform.position.x > highlightZebMeercat01.transform.position.x-2f
		    && transform.position.y < highlightZebMeercat01.transform.position.y+2f
		    && transform.position.y > highlightZebMeercat01.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebMeercat01.transform.position.x, highlightZebMeercat01.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebMeercat01);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
		}
		
		else if (highlightZebMeercat02 && timerMonkey.monkeyFinishedMeercat02 && monkey.transform.position != highlightZebMeercat02.transform.position && transform.position.x < highlightZebMeercat02.transform.position.x+2f
		         && transform.position.x > highlightZebMeercat02.transform.position.x-2f
		         && transform.position.y < highlightZebMeercat02.transform.position.y+2f
		         && transform.position.y > highlightZebMeercat02.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebMeercat02.transform.position.x, highlightZebMeercat02.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebMeercat02);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
		}
		
		else if (highlightZebMeercat03 && timerMonkey.monkeyFinishedMeercat03 && monkey.transform.position != highlightZebMeercat03.transform.position && transform.position.x < highlightZebMeercat03.transform.position.x+2f
		         && transform.position.x > highlightZebMeercat03.transform.position.x-2f
		         && transform.position.y < highlightZebMeercat03.transform.position.y+2f
		         && transform.position.y > highlightZebMeercat03.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebMeercat03.transform.position.x, highlightZebMeercat03.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebMeercat03);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
		}
		
		else if (highlightZebTeller01 && timerMonkey.monkeyFinishedTeller01 && monkey.transform.position != highlightZebTeller01.transform.position && transform.position.x < highlightZebTeller01.transform.position.x+2f
		         && transform.position.x > highlightZebTeller01.transform.position.x-2f
		         && transform.position.y < highlightZebTeller01.transform.position.y+2f
		         && transform.position.y > highlightZebTeller01.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller01.transform.position.x, highlightZebTeller01.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebTeller01);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
		}
		
		else if (highlightZebTeller03 && timerMonkey.monkeyFinishedTeller03 && monkey.transform.position != highlightZebTeller03.transform.position && transform.position.x < highlightZebTeller03.transform.position.x+2f
		         && transform.position.x > highlightZebTeller03.transform.position.x-2f
		         && transform.position.y < highlightZebTeller03.transform.position.y+2f
		         && transform.position.y > highlightZebTeller03.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller03.transform.position.x, highlightZebTeller03.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebTeller03);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
		}
		
		else 
		{
			this.drag.Play();
			transform.position = zebraDummy.transform.position;
			transform.localScale = new Vector3(-1f, 1f, 1);
			anim.SetBool("zebraDraged", false);
			timerZebra.renderer.enabled = false;
			timerZebra.timerOff();
			zebraIsInside = false;
		}


	}
	
	void OnMouseExit()
	{
		if (highlightZebMeercat01)
		{
			highlightZebMeercat01.renderer.enabled = false;
		}
		
		if (highlightZebMeercat02)
		{
			highlightZebMeercat02.renderer.enabled = false;
		}
		
		if (highlightZebMeercat03)
		{
			highlightZebMeercat03.renderer.enabled = false;
		}
		
		if (highlightZebTeller01)
		{
			highlightZebTeller01.renderer.enabled = false;
		}
		
		if (highlightZebTeller03)
		{
			highlightZebTeller03.renderer.enabled = false;
		}
	}
	
}

