﻿using UnityEngine;
using System.Collections;

public class safeBoxExplosion02_level07 : MonoBehaviour 
{
	rhino_Level_07 rhinoScript;
	Animator anim;
	
	private GameObject safeBoxObjectopened02;
	private GameObject safeBoxObject02;
	private GameObject  moneySafebox02;
	//private GameObject explosion;

	GameObject dog;
	gorilla_Level_07 gorillaScript;
	
	private Camera camera;
	Vector3 cameraPos;
	cameraZoonChange cameraShakeScript;
	
	void Start () 
	{
		dog = GameObject.Find ("dog");
		gorillaScript = GameObject.Find("gorilla").GetComponent<gorilla_Level_07>();

		rhinoScript = GameObject.Find("rhino").GetComponent<rhino_Level_07>();
		anim = this.GetComponent<Animator>();
		
		safeBoxObject02 = GameObject.Find ("safeBox02");
		safeBoxObjectopened02 = GameObject.Find ("safeBoxOpened02");
		
		moneySafebox02 = GameObject.Find ("moneySafebox02");
		
		camera = GameObject.Find ("Main Camera").GetComponent<Camera>();
		cameraShakeScript = GameObject.Find ("Main Camera").GetComponent<cameraZoonChange>();
		cameraPos = camera.transform.position;			
	}
	
	public void explosion () 
	{	
		if (rhinoScript.rhinoIsInside == true)
		{
			renderer.enabled = true;
			anim.SetBool("exploded", true);
			this.audio.Play();
			Handheld.Vibrate();
			if ( dog && (transform.position.x <= dog.transform.position.x+2)  && (transform.position.y <= dog.transform.position.y + 2) && !gorillaScript.gorillaIsInside)
			{
				Destroy (dog);
			}
			StartCoroutine (explodeDelay());
		}
	}
	
	IEnumerator explodeDelay()
	{
		if (rhinoScript.rhinoIsInside == true)
		{
			yield return new WaitForSeconds (.13f);
			Destroy (safeBoxObject02);
			safeBoxObjectopened02.renderer.enabled = true;
			moneySafebox02.renderer.enabled = true;
		}
		
	}
	
}
