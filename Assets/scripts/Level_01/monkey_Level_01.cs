﻿using UnityEngine;
using System.Collections;

public class monkey_Level_01 : MonoBehaviour {

	private Vector3 screenPoint;

	private GameObject highlightMonkey;
	private GameObject highLightZebra;
	private GameObject monkeyDummy;
	private GameObject handMonkey;
	private GameObject handZebra;
	private GameObject hintTimer;
	private GameObject hintZebra;
	private GameObject customersMoney;
	private GameObject timerObjectMonkey;
	public bool monkeyFinished;

	public AudioSource drag;
	public AudioSource monkeyDone;

	Animator anim;

	timerMonkey_Level_01 timerMonkey;


	void Start ()
	{ 
		AudioSource[] audios = GetComponents<AudioSource>();
		drag = audios[0];
		monkeyDone = audios[1];

		highlightMonkey = GameObject.Find ("highLightMonkey");
		highLightZebra = GameObject.Find ("highLightZebra");
		monkeyDummy = GameObject.Find ("monkeyDummy");
		handMonkey = GameObject.Find ("handMonkey");
		handZebra = GameObject.Find ("handZebra");
		hintTimer = GameObject.Find ("hintTimer");
		hintZebra = GameObject.Find ("hintZebra");
		customersMoney = GameObject.Find ("customersMoney");
		monkeyFinished = false;
		timerObjectMonkey = GameObject.Find ("timerObjectMonkey");
		
		timerMonkey = GameObject.Find ("timerObjectMonkey").GetComponent<timerMonkey_Level_01>();
				
		anim = this.GetComponent<Animator>();
	}	

	void OnMouseOver()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
	}

	void OnMouseDrag()  
	{	
		if (timerObjectMonkey.renderer.enabled == false)
		{
			Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
			Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
			transform.position = currentPos;
		}
	}
	
	
	void OnMouseUp () 
	{
		if (timerObjectMonkey.renderer.enabled == false)
		{
			if (highlightMonkey && transform.position.x < highlightMonkey.transform.position.x+2.5f
			    && transform.position.x > highlightMonkey.transform.position.x-2.5f
			    && transform.position.y < highlightMonkey.transform.position.y+2.5f
			    && transform.position.y > highlightMonkey.transform.position.y-2.5f
			    )
			{
				this.audio.Play();
				transform.position = new Vector3(highlightMonkey.transform.position.x, highlightMonkey.transform.position.y, 0);
				Destroy (highlightMonkey);
				anim.SetBool("monkeyDraged", true);
				handMonkey.renderer.enabled = false;
				timerMonkey.timerOn();

				hintTimer.renderer.enabled = true;
				Destroy(hintTimer,4.0f);
				customersMoney.renderer.enabled = true;
			}

			else if (handMonkey && !highlightMonkey)
			{
				this.drag.Play();
				Destroy(handMonkey);
				transform.position = new Vector3 (monkeyDummy.transform.position.x,monkeyDummy.transform.position.y,0);
				anim.SetBool("monkeyDraged", false);
				hintZebra.renderer.enabled = true;
				Destroy(hintZebra,6.0f);
				handZebra.renderer.enabled = true;
				highLightZebra.renderer.enabled = true;
				monkeyFinished = true;

			}

			else 
			{
				this.drag.Play();
				transform.position = new Vector3 (monkeyDummy.transform.position.x,monkeyDummy.transform.position.y,0);
				anim.SetBool("monkeyDraged", false);
			}
		}		
	}
	
}
