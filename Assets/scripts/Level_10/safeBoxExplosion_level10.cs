﻿using UnityEngine;
using System.Collections;

public class safeBoxExplosion_level10 : MonoBehaviour 
{
	rhino_Level_10 rhinoScript;
	Animator anim;
	
	GameObject safeBoxObjectopened;
	GameObject safeBoxObject;
	GameObject  moneySafebox;
	//GameObject explosion;

	GameObject dog;
	gorilla_Level_10 gorillaScript;

	Camera camera;
	Vector3 cameraPos;
	cameraZoonChange cameraShakeScript;
	
	void Start () 
	{

		dog = GameObject.Find ("dog");
		gorillaScript = GameObject.Find("gorilla").GetComponent<gorilla_Level_10>();

		rhinoScript = GameObject.Find("rhino").GetComponent<rhino_Level_10>();
		anim = this.GetComponent<Animator>();
		
		safeBoxObject = GameObject.Find ("safeBox");
		safeBoxObjectopened = GameObject.Find ("safeBoxOpened");
		
		moneySafebox = GameObject.Find ("moneySafebox");
		
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
			Destroy (safeBoxObject);
			safeBoxObjectopened.renderer.enabled = true;
			moneySafebox.renderer.enabled = true;
		}
		
		
		
	}
	
}