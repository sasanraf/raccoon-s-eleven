﻿using UnityEngine;
using System.Collections;

public class zebra_Level_01 : MonoBehaviour {

	
	private Vector3 screenPoint;
	
	private GameObject highLightZebra;
	private GameObject zebraDummy;
	private GameObject handZebra;
	private GameObject hintTimer;
	private GameObject hintZebra;
	private GameObject hintExcellent;
	private GameObject timerObjectZebra;
	Vector3 highLightZebraPositon;

	monkey_Level_01 monkeyFinishedCheck;

	public AudioSource drag;
	public AudioSource zebraDone;

	Animator anim;
	
	timerZebra_Level_01 timerZebra;
	
	
	void Start ()
	{ 

		AudioSource[] audios = GetComponents<AudioSource>();
		drag = audios[0];
		zebraDone = audios[1];

		highLightZebra = GameObject.Find ("highLightZebra");
		handZebra = GameObject.Find ("handZebra");
		hintTimer = GameObject.Find ("hintTimer");
		hintExcellent = GameObject.Find ("hintExcellent");
		hintZebra = GameObject.Find ("hintZebra");
		zebraDummy = GameObject.Find ("zebraDummy");
		timerObjectZebra = GameObject.Find ("timerObjectZebra");

		timerZebra = GameObject.Find ("timerObjectZebra").GetComponent<timerZebra_Level_01>();
		monkeyFinishedCheck = GameObject.Find ("monkey").GetComponent<monkey_Level_01>();

		anim = this.GetComponent<Animator>();
		highLightZebraPositon = highLightZebra.transform.position;

	}	
	
	void OnMouseOver()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
	}
	
	void OnMouseDrag()  
	{	
		if (monkeyFinishedCheck.monkeyFinished == true && timerObjectZebra.renderer.enabled == false)
		{
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
		transform.position = currentPos;
		}
	}
	
	
	void OnMouseUp () 
	{
		if (monkeyFinishedCheck.monkeyFinished == true && timerObjectZebra.renderer.enabled == false)
		{
			if (highLightZebra && transform.position.x < highLightZebra.transform.position.x+2.5f
			    && transform.position.x > highLightZebra.transform.position.x-2.5f
			    && transform.position.y < highLightZebra.transform.position.y+2.5f
			    && transform.position.y > highLightZebra.transform.position.y-2.5f
			    )
			{
				this.drag.Play();
				transform.position = new Vector3(highLightZebra.transform.position.x, highLightZebra.transform.position.y, 0);
				Destroy (highLightZebra);
				anim.SetBool("zebraDraged", true);
				handZebra.renderer.enabled = false;
				timerZebra.timerOn();
			}
			
			else if (!highLightZebra && (transform.position.x != highLightZebraPositon.x))
			{
				this.drag.Play();
				transform.position = new Vector3 (zebraDummy.transform.position.x,zebraDummy.transform.position.y,0);
				anim.SetBool("zebraDraged", false);
				if (hintZebra && hintZebra.renderer.enabled == true)
				{
					hintZebra.renderer.enabled = false;
				}
				Destroy (handZebra);
				hintExcellent.renderer.enabled = true;
				hintExcellent.collider2D.enabled = true;
				StartCoroutine("levelFinished");
			}
			
			else 
			{
				this.drag.Play();
				transform.position = new Vector3 (zebraDummy.transform.position.x, zebraDummy.transform.position.y, 0);
				anim.SetBool("zebraDraged", false);
			}
		}
	}

	IEnumerator levelFinished()
	{
		yield return new WaitForSeconds(5);
		PlayerPrefs.SetString("bankReg01_Bank02", "unlocked");
		Application.LoadLevel("L2_final");
	}



	
}

