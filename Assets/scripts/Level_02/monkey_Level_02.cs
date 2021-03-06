﻿using UnityEngine;
using System.Collections;

public class monkey_Level_02 : MonoBehaviour {

	//mouse and screen 
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

	private GameObject moneyTextMeercat01;
	private GameObject moneyTextMeercat02;
	private GameObject moneyTextMeercat03;
	private GameObject moneyTextTeller01;
	private GameObject moneyTextTeller03;

	private GameObject monkeyDummy;
	private GameObject hint;

	private GameObject moneyTeller01;
	private GameObject moneyTeller03;

	private GameObject timerObjectMonkey;

	public bool monkeyIsInside = false;

	//accessing monkey timer script
	timerMonkey_Level_02 timerMonkey;

	Animator anim;

	public AudioSource drag;
	public AudioSource monkeyDone;

	void Start ()
	{ 
		AudioSource[] audios = GetComponents<AudioSource>();
		drag = audios[0];
		monkeyDone = audios[1];

		timerObjectMonkey = GameObject.Find ("timerObjectMonkey");
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

		moneyTextMeercat01 = GameObject.Find ("moneyTextMeercat01");
		moneyTextMeercat02 = GameObject.Find ("moneyTextMeercat02");
		moneyTextMeercat03 = GameObject.Find ("moneyTextMeercat03");
		moneyTextTeller01 = GameObject.Find ("moneyTextTeller01");
		moneyTextTeller03 = GameObject.Find ("moneyTextTeller03");
		
		monkeyDummy = GameObject.Find ("monkeyDummy");

		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller03 = GameObject.Find ("moneyTeller03");
	
		anim = this.GetComponent<Animator>();
	}	
	
	void OnMouseOver()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

		if (highlightMonMeercat01)
		{
			highlightMonMeercat01.renderer.enabled = true;
		}
		
		if (highlightMonMeercat02)
		{
			highlightMonMeercat02.renderer.enabled = true;
		}
		
		if (highlightMonMeercat03)
		{
			highlightMonMeercat03.renderer.enabled = true;
		}
		
		if (highlightMonTeller01)
		{
			highlightMonTeller01.renderer.enabled = true;
		}

		if (highlightMonTeller03)
		{
			highlightMonTeller03.renderer.enabled = true;
		}

	}
	
	void OnMouseDrag()  
	{		
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
		transform.position = currentPos;

		//check if player move monkey before timer finish and destroy the zebra highlight 
		if (timerObjectMonkey.renderer.enabled == true)
		{
			if (timerMonkey.monkeyFinishedMeercat01 == false && highlightZebMeercat01 && transform.position.x < highlightZebMeercat01.transform.position.x+2f
			    && transform.position.x > highlightZebMeercat01.transform.position.x-2f
			    && transform.position.y < highlightZebMeercat01.transform.position.y+2f
			    && transform.position.y > highlightZebMeercat01.transform.position.y-2f
			    )
			{
				timerMonkey.StopCoroutine("waitOnPlay");
				Destroy (moneyTextMeercat01);
				timerMonkey.timeroff();
				Destroy (highlightZebMeercat01);
			}
			
			else if (timerMonkey.monkeyFinishedMeercat02 == false && highlightZebMeercat02 && transform.position.x < highlightZebMeercat02.transform.position.x+2f
			         && transform.position.x > highlightZebMeercat02.transform.position.x-2f
			         && transform.position.y < highlightZebMeercat02.transform.position.y+2f
			         && transform.position.y > highlightZebMeercat02.transform.position.y-2f
			         )
			{
				timerMonkey.StopCoroutine("waitOnPlay");
				Destroy (moneyTextMeercat02);
				timerMonkey.timeroff();
				Destroy (highlightZebMeercat02);
			}
			
			else if (timerMonkey.monkeyFinishedMeercat03 == false && highlightZebMeercat03 && transform.position.x < highlightZebMeercat03.transform.position.x+2f
			         && transform.position.x > highlightZebMeercat03.transform.position.x-2f
			         && transform.position.y < highlightZebMeercat03.transform.position.y+2f
			         && transform.position.y > highlightZebMeercat03.transform.position.y-2f
			         )
			{
				timerMonkey.StopCoroutine("waitOnPlay");
				Destroy (moneyTextMeercat03);
				timerMonkey.timeroff();
				Destroy (highlightZebMeercat03);
			}
			
			else if (timerMonkey.monkeyFinishedTeller01 == false && highlightZebTeller01 && transform.position.x < highlightZebTeller01.transform.position.x+2f
			         && transform.position.x > highlightZebTeller01.transform.position.x-2f
			         && transform.position.y < highlightZebTeller01.transform.position.y+2f
			         && transform.position.y > highlightZebTeller01.transform.position.y-2f
			         )
			{
				timerMonkey.StopCoroutine("waitOnPlay");
				Destroy (moneyTextTeller01);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller01);
			}

			else if (timerMonkey.monkeyFinishedTeller03 == false && highlightZebTeller03 && transform.position.x < highlightZebTeller03.transform.position.x+2f
			         && transform.position.x > highlightZebTeller03.transform.position.x-2f
			         && transform.position.y < highlightZebTeller03.transform.position.y+2f
			         && transform.position.y > highlightZebTeller03.transform.position.y-2f
			         )
			{
				timerMonkey.StopCoroutine("waitOnPlay");
				Destroy (moneyTextTeller03);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller03);
			}		
		}
	}
	
	void OnMouseUp () 
	{
		
		if (highlightMonMeercat01 && transform.position.x < highlightMonMeercat01.transform.position.x+2f
		    && transform.position.x > highlightMonMeercat01.transform.position.x-2f
		    && transform.position.y < highlightMonMeercat01.transform.position.y+2f
		    && transform.position.y > highlightMonMeercat01.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonMeercat01.transform.position.x, highlightMonMeercat01.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonMeercat01);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
		}
		
		else if (highlightMonMeercat02 && transform.position.x < highlightMonMeercat02.transform.position.x+2f
		         && transform.position.x > highlightMonMeercat02.transform.position.x-2f
		         && transform.position.y < highlightMonMeercat02.transform.position.y+2f
		         && transform.position.y > highlightMonMeercat02.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonMeercat02.transform.position.x, highlightMonMeercat02.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonMeercat02);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
		}
		
		else if (highlightMonMeercat03 && transform.position.x < highlightMonMeercat03.transform.position.x+2f
		         && transform.position.x > highlightMonMeercat03.transform.position.x-2f
		         && transform.position.y < highlightMonMeercat03.transform.position.y+2f
		         && transform.position.y > highlightMonMeercat03.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonMeercat03.transform.position.x, highlightMonMeercat03.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonMeercat03);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
		}
		
		else if (highlightMonTeller01 && transform.position.x < highlightMonTeller01.transform.position.x+2f
		         && transform.position.x > highlightMonTeller01.transform.position.x-2f
		         && transform.position.y < highlightMonTeller01.transform.position.y+2f
		         && transform.position.y > highlightMonTeller01.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller01.transform.position.x, highlightMonTeller01.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonTeller01);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
		}

		else if (highlightMonTeller03 && transform.position.x < highlightMonTeller03.transform.position.x+2f
		         && transform.position.x > highlightMonTeller03.transform.position.x-2f
		         && transform.position.y < highlightMonTeller03.transform.position.y+2f
		         && transform.position.y > highlightMonTeller03.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller03.transform.position.x, highlightMonTeller03.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonTeller03);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
		}
		
		else 
		{
			this.drag.Play();
			transform.position = monkeyDummy.transform.position;
			transform.localScale = new Vector3(-1f, 1f, 1);
			anim.SetBool("monkeyDraged", false);
			timerMonkey.renderer.enabled = false;
			monkeyIsInside = false;
		}
		
	}
	
	void OnMouseExit()
	{

		if (highlightMonMeercat01)
		{
			highlightMonMeercat01.renderer.enabled = false;
		}
		
		if (highlightMonMeercat02)
		{
			highlightMonMeercat02.renderer.enabled = false;
		}
		
		if (highlightMonMeercat03)
		{
			highlightMonMeercat03.renderer.enabled = false;
		}
		
		if (highlightMonTeller01)
		{
			highlightMonTeller01.renderer.enabled = false;
		}

		if (highlightMonTeller03)
		{
			highlightMonTeller03.renderer.enabled = false;
		}

	}
	
}
