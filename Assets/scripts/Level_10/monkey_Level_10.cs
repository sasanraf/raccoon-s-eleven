﻿using UnityEngine;
using System.Collections;

public class monkey_Level_10 : MonoBehaviour {
	
	//mouse and screen 
	Vector3 screenPoint;
	float mouseX;
	float mouseY;
	Vector3 mouseposition;
	
	Vector3 shelfPos;
	
	//highlights monkey
	GameObject highlightMonMeercat01;
	GameObject highlightMonMeercat02;
	GameObject highlightMonMeercat03;
	GameObject highlightMonMeercat04;
	GameObject highlightMonMeercat05;
	GameObject highlightMonMeercat06;
	GameObject highlightMonRabbit01;
	GameObject highlightMonRabbit02;
	GameObject highlightMonRabbit03;
	GameObject highlightMonRabbit04;
	GameObject highlightMonRabbit05;
	GameObject highlightMonTeller01;
	GameObject highlightMonTeller02;
	GameObject highlightMonTeller03;
	GameObject highlightMonTeller04;
	GameObject highlightMonTeller05;
	GameObject highlightMonTeller06;
	GameObject highlightMonTeller07;
	GameObject highlightMonTeller08;
	GameObject highlightMonTeller09;
	GameObject highlightMonTeller10;
	
	//highlight zebra
	GameObject highlightZebMeercat01;
	GameObject highlightZebMeercat02;
	GameObject highlightZebMeercat03;
	GameObject highlightZebMeercat04;
	GameObject highlightZebMeercat05;
	GameObject highlightZebMeercat06;
	GameObject highlightZebRabbit01;
	GameObject highlightZebRabbit02;
	GameObject highlightZebRabbit03;
	GameObject highlightZebRabbit04;
	GameObject highlightZebRabbit05;	
	GameObject highlightZebTeller01;
	GameObject highlightZebTeller02;
	GameObject highlightZebTeller03;
	GameObject highlightZebTeller04;
	GameObject highlightZebTeller05;
	GameObject highlightZebTeller06;
	GameObject highlightZebTeller07;
	GameObject highlightZebTeller08;
	GameObject highlightZebTeller09;
	GameObject highlightZebTeller10;
	
	GameObject moneyTextMeercat01;
	GameObject moneyTextMeercat02;
	GameObject moneyTextMeercat03;
	GameObject moneyTextMeercat04;
	GameObject moneyTextMeercat05;
	GameObject moneyTextMeercat06;
	GameObject moneyTextRabbit01;
	GameObject moneyTextRabbit02;
	GameObject moneyTextRabbit03;
	GameObject moneyTextRabbit04;
	GameObject moneyTextRabbit05;
	GameObject moneyTextTeller01;
	GameObject moneyTextTeller02;
	GameObject moneyTextTeller03;
	GameObject moneyTextTeller04;
	GameObject moneyTextTeller05;
	GameObject moneyTextTeller06;
	GameObject moneyTextTeller07;
	GameObject moneyTextTeller08;
	GameObject moneyTextTeller09;
	GameObject moneyTextTeller10;
	
	GameObject hint;
	
	GameObject moneyTeller01;
	GameObject moneyTeller02;
	GameObject moneyTeller03;
	GameObject moneyTeller04;
	GameObject moneyTeller05;
	GameObject moneyTeller06;
	GameObject moneyTeller07;
	GameObject moneyTeller08;
	GameObject moneyTeller09;
	GameObject moneyTeller10;
	
	GameObject timerObjectMonkey;
	
	public bool monkeyIsInside = false;
	
	//accessing monkey timer script
	timerMonkey_Level_10 timerMonkey;
	
	Animator anim;
	
	public AudioSource drag;
	public AudioSource moneyDone;

	GameObject dummyPos1;
	GameObject dummyPos2;
	GameObject dummyPos3;
	GameObject dummyPos4;
	
	GameObject monkeyDummy;

	public int dummyPosNo;
	public GameObject dummyPosition;

	GameObject dummyCameraZoon01;
	GameObject dummyCameraZoon02;

	GameObject camera;

	void Start ()
	{ 

		dummyCameraZoon01 = GameObject.Find ("dummyCameraZoon01");
		dummyCameraZoon02 = GameObject.Find ("dummyCameraZoon02");
		camera = GameObject.Find ("Main Camera");

		AudioSource[] audios = GetComponents<AudioSource>();
		drag = audios[0];
		moneyDone = audios[1];
		
		//monkey position on shelf
		dummyPos1 = GameObject.Find ("dummyPos1");
		dummyPos2 = GameObject.Find ("dummyPos2");
		dummyPos3 = GameObject.Find ("dummyPos3");
		dummyPos4 = GameObject.Find ("dummyPos4");

		monkeyDummy = GameObject.Find ("monkeyDummy");

		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		highlightZebMeercat02 = GameObject.Find ("highlightZebMeercat02");
		highlightZebMeercat03 = GameObject.Find ("highlightZebMeercat03");
		highlightZebMeercat04 = GameObject.Find ("highlightZebMeercat04");
		highlightZebMeercat05 = GameObject.Find ("highlightZebMeercat05");
		highlightZebMeercat06 = GameObject.Find ("highlightZebMeercat06");
		highlightZebRabbit01 = GameObject.Find ("highlightZebRabbit01");
		highlightZebRabbit02 = GameObject.Find ("highlightZebRabbit02");
		highlightZebRabbit03 = GameObject.Find ("highlightZebRabbit03");
		highlightZebRabbit04 = GameObject.Find ("highlightZebRabbit04");
		highlightZebRabbit05 = GameObject.Find ("highlightZebRabbit05");
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		highlightZebTeller02 = GameObject.Find ("highlightZebTeller02");
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");
		highlightZebTeller04 = GameObject.Find ("highlightZebTeller04");
		highlightZebTeller05 = GameObject.Find ("highlightZebTeller05");
		highlightZebTeller06 = GameObject.Find ("highlightZebTeller06");
		highlightZebTeller07 = GameObject.Find ("highlightZebTeller07");
		highlightZebTeller08 = GameObject.Find ("highlightZebTeller08");
		highlightZebTeller09 = GameObject.Find ("highlightZebTeller09");
		highlightZebTeller10 = GameObject.Find ("highlightZebTeller10");
		
		if (PlayerPrefs.GetString("chaPos1") == "monkey")
		{
			transform.position = dummyPos1.transform.position;
			shelfPos = dummyPos1.transform.position;
			monkeyDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos2") == "monkey")
		{
			transform.position = dummyPos2.transform.position;
			shelfPos = dummyPos2.transform.position;
			monkeyDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos3") == "monkey")
		{
			transform.position = dummyPos3.transform.position;
			shelfPos = dummyPos3.transform.position;
			monkeyDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos4") == "monkey")
		{
			transform.position = dummyPos4.transform.position;
			shelfPos = dummyPos4.transform.position;
			monkeyDummy.transform.position = shelfPos;
		}

		else if ( highlightZebMeercat01)
		{
			Destroy(highlightZebMeercat01);
			Destroy(highlightZebMeercat02);
			Destroy(highlightZebMeercat03);
			Destroy(highlightZebMeercat04);
			Destroy(highlightZebMeercat05);
			Destroy(highlightZebMeercat06);
			Destroy(highlightZebRabbit01);
			Destroy(highlightZebRabbit02);
			Destroy(highlightZebRabbit03);
			Destroy(highlightZebRabbit04);
			Destroy(highlightZebRabbit05);
			Destroy(highlightZebTeller01);
			Destroy(highlightZebTeller02);
			Destroy(highlightZebTeller03);
			Destroy(highlightZebTeller04);
			Destroy(highlightZebTeller05);
			Destroy(highlightZebTeller06);
			Destroy(highlightZebTeller07);
			Destroy(highlightZebTeller08);
			Destroy(highlightZebTeller09);
			Destroy(highlightZebTeller10);
		}

		dummyPosition = GameObject.Find ("dummyPos"+dummyPosNo);

		timerObjectMonkey = GameObject.Find ("timerObjectMonkey");
		timerMonkey = GameObject.Find ("timerObjectMonkey").GetComponent<timerMonkey_Level_10>();
		
		highlightMonMeercat01 = GameObject.Find ("highlightMonMeercat01");
		highlightMonMeercat02 = GameObject.Find ("highlightMonMeercat02");
		highlightMonMeercat03 = GameObject.Find ("highlightMonMeercat03");
		highlightMonMeercat04 = GameObject.Find ("highlightMonMeercat04");
		highlightMonMeercat05 = GameObject.Find ("highlightMonMeercat05");
		highlightMonMeercat06 = GameObject.Find ("highlightMonMeercat06");
		highlightMonRabbit01 = GameObject.Find ("highlightMonRabbit01");
		highlightMonRabbit02 = GameObject.Find ("highlightMonRabbit02");
		highlightMonRabbit03 = GameObject.Find ("highlightMonRabbit03");
		highlightMonRabbit04 = GameObject.Find ("highlightMonRabbit04");
		highlightMonRabbit05 = GameObject.Find ("highlightMonRabbit05");
		highlightMonTeller01 = GameObject.Find ("highlightMonTeller01");
		highlightMonTeller02 = GameObject.Find ("highlightMonTeller02");
		highlightMonTeller03 = GameObject.Find ("highlightMonTeller03");
		highlightMonTeller04 = GameObject.Find ("highlightMonTeller04");
		highlightMonTeller05 = GameObject.Find ("highlightMonTeller05");
		highlightMonTeller06 = GameObject.Find ("highlightMonTeller06");
		highlightMonTeller07 = GameObject.Find ("highlightMonTeller07");
		highlightMonTeller08 = GameObject.Find ("highlightMonTeller08");
		highlightMonTeller09 = GameObject.Find ("highlightMonTeller09");
		highlightMonTeller10 = GameObject.Find ("highlightMonTeller10");
		
		moneyTextMeercat01 = GameObject.Find ("moneyTextMeercat01");
		moneyTextMeercat02 = GameObject.Find ("moneyTextMeercat02");
		moneyTextMeercat03 = GameObject.Find ("moneyTextMeercat03");
		moneyTextMeercat04 = GameObject.Find ("moneyTextMeercat04");
		moneyTextMeercat05 = GameObject.Find ("moneyTextMeercat05");
		moneyTextMeercat06 = GameObject.Find ("moneyTextMeercat06");
		moneyTextRabbit01 = GameObject.Find ("moneyTextRabbit01");
		moneyTextRabbit02 = GameObject.Find ("moneyTextRabbit02");
		moneyTextRabbit03 = GameObject.Find ("moneyTextRabbit03");
		moneyTextRabbit04 = GameObject.Find ("moneyTextRabbit04");
		moneyTextRabbit05 = GameObject.Find ("moneyTextRabbit06");
		moneyTextTeller01 = GameObject.Find ("moneyTextTeller01");
		moneyTextTeller02 = GameObject.Find ("moneyTextTeller02");
		moneyTextTeller03 = GameObject.Find ("moneyTextTeller03");
		moneyTextTeller04 = GameObject.Find ("moneyTextTeller04");
		moneyTextTeller05 = GameObject.Find ("moneyTextTeller05");
		moneyTextTeller06 = GameObject.Find ("moneyTextTeller06");
		moneyTextTeller07 = GameObject.Find ("moneyTextTeller07");
		moneyTextTeller08 = GameObject.Find ("moneyTextTeller08");
		moneyTextTeller09 = GameObject.Find ("moneyTextTeller09");
		moneyTextTeller10 = GameObject.Find ("moneyTextTeller10");
		
		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller02 = GameObject.Find ("moneyTeller02");
		moneyTeller03 = GameObject.Find ("moneyTeller03");
		moneyTeller04 = GameObject.Find ("moneyTeller04");
		moneyTeller05 = GameObject.Find ("moneyTeller05");
		moneyTeller06 = GameObject.Find ("moneyTeller06");
		moneyTeller07 = GameObject.Find ("moneyTeller07");
		moneyTeller08 = GameObject.Find ("moneyTeller08");
		moneyTeller09 = GameObject.Find ("moneyTeller09");
		moneyTeller10 = GameObject.Find ("moneyTeller10");
		
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
		if (highlightMonMeercat04)
		{
			highlightMonMeercat04.renderer.enabled = true;
		}
		if (highlightMonMeercat05)
		{
			highlightMonMeercat05.renderer.enabled = true;
		}
		if (highlightMonMeercat06)
		{
			highlightMonMeercat06.renderer.enabled = true;
		}
		
		if (highlightMonRabbit01)
		{
			highlightMonRabbit01.renderer.enabled = true;
		}		
		if (highlightMonRabbit02)
		{
			highlightMonRabbit02.renderer.enabled = true;
		}		
		if (highlightMonRabbit03)
		{
			highlightMonRabbit03.renderer.enabled = true;
		}		
		if (highlightMonRabbit04)
		{
			highlightMonRabbit04.renderer.enabled = true;
		}
		if (highlightMonRabbit05)
		{
			highlightMonRabbit05.renderer.enabled = true;
		}			
		if (highlightMonTeller01)
		{
			highlightMonTeller01.renderer.enabled = true;
		}	
		if (highlightMonTeller02)
		{
			highlightMonTeller02.renderer.enabled = true;
		}	
		if (highlightMonTeller03)
		{
			highlightMonTeller03.renderer.enabled = true;
		}		
		if (highlightMonTeller04)
		{
			highlightMonTeller04.renderer.enabled = true;
		}
		if (highlightMonTeller05)
		{
			highlightMonTeller05.renderer.enabled = true;
		}
		if (highlightMonTeller06)
		{
			highlightMonTeller06.renderer.enabled = true;
		}
		if (highlightMonTeller07)
		{
			highlightMonTeller07.renderer.enabled = true;
		}			
		if (highlightMonTeller08)
		{
			highlightMonTeller08.renderer.enabled = true;
		}
		if (highlightMonTeller09)
		{
			highlightMonTeller09.renderer.enabled = true;
		}
		if (highlightMonTeller10)
		{
			highlightMonTeller10.renderer.enabled = true;
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
				Destroy (moneyTextMeercat01);
				timerMonkey.timeroff();
				Destroy (highlightZebMeercat01);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedMeercat02 == false && highlightZebMeercat02 && transform.position.x < highlightZebMeercat02.transform.position.x+2f
			    && transform.position.x > highlightZebMeercat02.transform.position.x-2f
			    && transform.position.y < highlightZebMeercat02.transform.position.y+2f
			    && transform.position.y > highlightZebMeercat02.transform.position.y-2f
			    )
			{
				Destroy (moneyTextMeercat02);
				timerMonkey.timeroff();
				Destroy (highlightZebMeercat02);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedMeercat03 == false && highlightZebMeercat03 && transform.position.x < highlightZebMeercat03.transform.position.x+2f
			    && transform.position.x > highlightZebMeercat03.transform.position.x-2f
			    && transform.position.y < highlightZebMeercat03.transform.position.y+2f
			    && transform.position.y > highlightZebMeercat03.transform.position.y-2f
			    )
			{
				Destroy (moneyTextMeercat03);
				timerMonkey.timeroff();
				Destroy (highlightZebMeercat03);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedMeercat04 == false && highlightZebMeercat04 && transform.position.x < highlightZebMeercat04.transform.position.x+2f
			    && transform.position.x > highlightZebMeercat04.transform.position.x-2f
			    && transform.position.y < highlightZebMeercat04.transform.position.y+2f
			    && transform.position.y > highlightZebMeercat04.transform.position.y-2f
			    )
			{
				Destroy (moneyTextMeercat04);
				timerMonkey.timeroff();
				Destroy (highlightZebMeercat04);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedMeercat05 == false && highlightZebMeercat05 && transform.position.x < highlightZebMeercat05.transform.position.x+2f
			    && transform.position.x > highlightZebMeercat05.transform.position.x-2f
			    && transform.position.y < highlightZebMeercat05.transform.position.y+2f
			    && transform.position.y > highlightZebMeercat05.transform.position.y-2f
			    )
			{
				Destroy (moneyTextMeercat05);
				timerMonkey.timeroff();
				Destroy (highlightZebMeercat05);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedMeercat06 == false && highlightZebMeercat06 && transform.position.x < highlightZebMeercat06.transform.position.x+2f
			    && transform.position.x > highlightZebMeercat06.transform.position.x-2f
			    && transform.position.y < highlightZebMeercat06.transform.position.y+2f
			    && transform.position.y > highlightZebMeercat06.transform.position.y-2f
			    )
			{
				Destroy (moneyTextMeercat06);
				timerMonkey.timeroff();
				Destroy (highlightZebMeercat06);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
		
			else if (timerMonkey.monkeyFinishedRabbit01 == false && highlightZebRabbit01 && transform.position.x < highlightZebRabbit01.transform.position.x+2f
			         && transform.position.x > highlightZebRabbit01.transform.position.x-2f
			         && transform.position.y < highlightZebRabbit01.transform.position.y+2f
			         && transform.position.y > highlightZebRabbit01.transform.position.y-2f
			         )
			{
				Destroy (moneyTextRabbit01);
				timerMonkey.timeroff();
				Destroy (highlightZebRabbit01);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedRabbit02 == false && highlightZebRabbit02 && transform.position.x < highlightZebRabbit02.transform.position.x+2f
			         && transform.position.x > highlightZebRabbit02.transform.position.x-2f
			         && transform.position.y < highlightZebRabbit02.transform.position.y+2f
			         && transform.position.y > highlightZebRabbit02.transform.position.y-2f
			         )
			{
				Destroy (moneyTextRabbit02);
				timerMonkey.timeroff();
				Destroy (highlightZebRabbit02);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedRabbit03 == false && highlightZebRabbit03 && transform.position.x < highlightZebRabbit03.transform.position.x+2f
			         && transform.position.x > highlightZebRabbit03.transform.position.x-2f
			         && transform.position.y < highlightZebRabbit03.transform.position.y+2f
			         && transform.position.y > highlightZebRabbit03.transform.position.y-2f
			         )
			{
				Destroy (moneyTextRabbit03);
				timerMonkey.timeroff();
				Destroy (highlightZebRabbit03);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedRabbit04 == false && highlightZebRabbit04 && transform.position.x < highlightZebRabbit04.transform.position.x+2f
			         && transform.position.x > highlightZebRabbit04.transform.position.x-2f
			         && transform.position.y < highlightZebRabbit04.transform.position.y+2f
			         && transform.position.y > highlightZebRabbit04.transform.position.y-2f
			         )
			{
				Destroy (moneyTextRabbit04);
				timerMonkey.timeroff();
				Destroy (highlightZebRabbit04);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedRabbit05 == false && highlightZebRabbit05 && transform.position.x < highlightZebRabbit05.transform.position.x+2f
			         && transform.position.x > highlightZebRabbit05.transform.position.x-2f
			         && transform.position.y < highlightZebRabbit05.transform.position.y+2f
			         && transform.position.y > highlightZebRabbit05.transform.position.y-2f
			         )
			{
				Destroy (moneyTextRabbit05);
				timerMonkey.timeroff();
				Destroy (highlightZebRabbit05);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedTeller01 == false && highlightZebTeller01 && transform.position.x < highlightZebTeller01.transform.position.x+2f
			         && transform.position.x > highlightZebTeller01.transform.position.x-2f
			         && transform.position.y < highlightZebTeller01.transform.position.y+2f
			         && transform.position.y > highlightZebTeller01.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller01);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller01);
				timerMonkey.StopCoroutine("waitOnPlay");
			}
			
			else if (timerMonkey.monkeyFinishedTeller02 == false && highlightZebTeller02 && transform.position.x < highlightZebTeller02.transform.position.x+2f
			         && transform.position.x > highlightZebTeller02.transform.position.x-2f
			         && transform.position.y < highlightZebTeller02.transform.position.y+2f
			         && transform.position.y > highlightZebTeller02.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller02);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller02);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedTeller03 == false && highlightZebTeller03 && transform.position.x < highlightZebTeller03.transform.position.x+2f
			         && transform.position.x > highlightZebTeller03.transform.position.x-2f
			         && transform.position.y < highlightZebTeller03.transform.position.y+2f
			         && transform.position.y > highlightZebTeller03.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller03);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller03);
				timerMonkey.StopCoroutine("waitOnPlay");

			}		
			
			else if (timerMonkey.monkeyFinishedTeller04 == false && highlightZebTeller04 && transform.position.x < highlightZebTeller04.transform.position.x+2f
			         && transform.position.x > highlightZebTeller04.transform.position.x-2f
			         && transform.position.y < highlightZebTeller04.transform.position.y+2f
			         && transform.position.y > highlightZebTeller04.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller04);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller04);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			
			else if (timerMonkey.monkeyFinishedTeller05 == false && highlightZebTeller05 && transform.position.x < highlightZebTeller05.transform.position.x+2f
			         && transform.position.x > highlightZebTeller05.transform.position.x-2f
			         && transform.position.y < highlightZebTeller05.transform.position.y+2f
			         && transform.position.y > highlightZebTeller05.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller05);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller05);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			else if (timerMonkey.monkeyFinishedTeller06 == false && highlightZebTeller06 && transform.position.x < highlightZebTeller06.transform.position.x+2f
			         && transform.position.x > highlightZebTeller06.transform.position.x-2f
			         && transform.position.y < highlightZebTeller06.transform.position.y+2f
			         && transform.position.y > highlightZebTeller06.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller06);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller06);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			else if (timerMonkey.monkeyFinishedTeller07 == false && highlightZebTeller07 && transform.position.x < highlightZebTeller07.transform.position.x+2f
			         && transform.position.x > highlightZebTeller07.transform.position.x-2f
			         && transform.position.y < highlightZebTeller07.transform.position.y+2f
			         && transform.position.y > highlightZebTeller07.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller07);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller07);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			else if (timerMonkey.monkeyFinishedTeller08 == false && highlightZebTeller08 && transform.position.x < highlightZebTeller08.transform.position.x+2f
			         && transform.position.x > highlightZebTeller08.transform.position.x-2f
			         && transform.position.y < highlightZebTeller08.transform.position.y+2f
			         && transform.position.y > highlightZebTeller08.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller08);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller08);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			else if (timerMonkey.monkeyFinishedTeller09 == false && highlightZebTeller09 && transform.position.x < highlightZebTeller09.transform.position.x+2f
			         && transform.position.x > highlightZebTeller09.transform.position.x-2f
			         && transform.position.y < highlightZebTeller09.transform.position.y+2f
			         && transform.position.y > highlightZebTeller09.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller09);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller09);
				timerMonkey.StopCoroutine("waitOnPlay");

			}
			else if (timerMonkey.monkeyFinishedTeller10 == false && highlightZebTeller10 && transform.position.x < highlightZebTeller10.transform.position.x+2f
			         && transform.position.x > highlightZebTeller10.transform.position.x-2f
			         && transform.position.y < highlightZebTeller10.transform.position.y+2f
			         && transform.position.y > highlightZebTeller10.transform.position.y-2f
			         )
			{
				Destroy (moneyTextTeller10);
				timerMonkey.timeroff();
				Destroy (highlightZebTeller10);
				timerMonkey.StopCoroutine("waitOnPlay");

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
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonMeercat01);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}	
		
		else if (highlightMonMeercat02 && transform.position.x < highlightMonMeercat02.transform.position.x+2f
		    && transform.position.x > highlightMonMeercat02.transform.position.x-2f
		    && transform.position.y < highlightMonMeercat02.transform.position.y+2f
		    && transform.position.y > highlightMonMeercat02.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonMeercat02.transform.position.x, highlightMonMeercat02.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonMeercat02);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}	
		
		else if (highlightMonMeercat03 && transform.position.x < highlightMonMeercat03.transform.position.x+2f
		    && transform.position.x > highlightMonMeercat03.transform.position.x-2f
		    && transform.position.y < highlightMonMeercat03.transform.position.y+2f
		    && transform.position.y > highlightMonMeercat03.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonMeercat03.transform.position.x, highlightMonMeercat03.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonMeercat03);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}	
		
		else if (highlightMonMeercat04 && transform.position.x < highlightMonMeercat04.transform.position.x+2f
		    && transform.position.x > highlightMonMeercat04.transform.position.x-2f
		    && transform.position.y < highlightMonMeercat04.transform.position.y+2f
		    && transform.position.y > highlightMonMeercat04.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonMeercat04.transform.position.x, highlightMonMeercat04.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonMeercat04);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}	
		
		else if (highlightMonMeercat05 && transform.position.x < highlightMonMeercat05.transform.position.x+2f
		    && transform.position.x > highlightMonMeercat05.transform.position.x-2f
		    && transform.position.y < highlightMonMeercat05.transform.position.y+2f
		    && transform.position.y > highlightMonMeercat05.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonMeercat05.transform.position.x, highlightMonMeercat05.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonMeercat05);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}	
		
		else if (highlightMonMeercat06 && transform.position.x < highlightMonMeercat06.transform.position.x+2f
		    && transform.position.x > highlightMonMeercat06.transform.position.x-2f
		    && transform.position.y < highlightMonMeercat06.transform.position.y+2f
		    && transform.position.y > highlightMonMeercat06.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonMeercat06.transform.position.x, highlightMonMeercat06.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonMeercat06);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}	

		
		else if (highlightMonRabbit01 && transform.position.x < highlightMonRabbit01.transform.position.x+2f
		         && transform.position.x > highlightMonRabbit01.transform.position.x-2f
		         && transform.position.y < highlightMonRabbit01.transform.position.y+2f
		         && transform.position.y > highlightMonRabbit01.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonRabbit01.transform.position.x, highlightMonRabbit01.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonRabbit01);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightMonRabbit02 && transform.position.x < highlightMonRabbit02.transform.position.x+2f
		         && transform.position.x > highlightMonRabbit02.transform.position.x-2f
		         && transform.position.y < highlightMonRabbit02.transform.position.y+2f
		         && transform.position.y > highlightMonRabbit02.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonRabbit02.transform.position.x, highlightMonRabbit02.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonRabbit02);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightMonRabbit03 && transform.position.x < highlightMonRabbit03.transform.position.x+2f
		         && transform.position.x > highlightMonRabbit03.transform.position.x-2f
		         && transform.position.y < highlightMonRabbit03.transform.position.y+2f
		         && transform.position.y > highlightMonRabbit03.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonRabbit03.transform.position.x, highlightMonRabbit03.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonRabbit03);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightMonRabbit04 && transform.position.x < highlightMonRabbit04.transform.position.x+2f
		         && transform.position.x > highlightMonRabbit04.transform.position.x-2f
		         && transform.position.y < highlightMonRabbit04.transform.position.y+2f
		         && transform.position.y > highlightMonRabbit04.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonRabbit04.transform.position.x, highlightMonRabbit04.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonRabbit04);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightMonRabbit05 && transform.position.x < highlightMonRabbit05.transform.position.x+2f
		         && transform.position.x > highlightMonRabbit05.transform.position.x-2f
		         && transform.position.y < highlightMonRabbit05.transform.position.y+2f
		         && transform.position.y > highlightMonRabbit05.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonRabbit05.transform.position.x, highlightMonRabbit05.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonRabbit05);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
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
			transform.parent = null;
		}
		
		else if (highlightMonTeller02 && transform.position.x < highlightMonTeller02.transform.position.x+2f
		         && transform.position.x > highlightMonTeller02.transform.position.x-2f
		         && transform.position.y < highlightMonTeller02.transform.position.y+2f
		         && transform.position.y > highlightMonTeller02.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller02.transform.position.x, highlightMonTeller02.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonTeller02);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
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
			transform.parent = null;
		}
		
		else if (highlightMonTeller04 && transform.position.x < highlightMonTeller04.transform.position.x+2f
		         && transform.position.x > highlightMonTeller04.transform.position.x-2f
		         && transform.position.y < highlightMonTeller04.transform.position.y+2f
		         && transform.position.y > highlightMonTeller04.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller04.transform.position.x, highlightMonTeller04.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonTeller04);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightMonTeller05 && transform.position.x < highlightMonTeller05.transform.position.x+2f
		         && transform.position.x > highlightMonTeller05.transform.position.x-2f
		         && transform.position.y < highlightMonTeller05.transform.position.y+2f
		         && transform.position.y > highlightMonTeller05.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller05.transform.position.x, highlightMonTeller05.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonTeller05);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightMonTeller06 && transform.position.x < highlightMonTeller06.transform.position.x+2f
		         && transform.position.x > highlightMonTeller06.transform.position.x-2f
		         && transform.position.y < highlightMonTeller06.transform.position.y+2f
		         && transform.position.y > highlightMonTeller06.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller06.transform.position.x, highlightMonTeller06.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonTeller06);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		
		else if (highlightMonTeller07 && transform.position.x < highlightMonTeller07.transform.position.x+2f
		         && transform.position.x > highlightMonTeller07.transform.position.x-2f
		         && transform.position.y < highlightMonTeller07.transform.position.y+2f
		         && transform.position.y > highlightMonTeller07.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller07.transform.position.x, highlightMonTeller07.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightMonTeller07);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightMonTeller08 && transform.position.x < highlightMonTeller08.transform.position.x+2f
		         && transform.position.x > highlightMonTeller08.transform.position.x-2f
		         && transform.position.y < highlightMonTeller08.transform.position.y+2f
		         && transform.position.y > highlightMonTeller08.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller08.transform.position.x, highlightMonTeller08.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonTeller08);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightMonTeller09 && transform.position.x < highlightMonTeller09.transform.position.x+2f
		         && transform.position.x > highlightMonTeller09.transform.position.x-2f
		         && transform.position.y < highlightMonTeller09.transform.position.y+2f
		         && transform.position.y > highlightMonTeller09.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller09.transform.position.x, highlightMonTeller09.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonTeller09);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightMonTeller10 && transform.position.x < highlightMonTeller10.transform.position.x+2f
		         && transform.position.x > highlightMonTeller10.transform.position.x-2f
		         && transform.position.y < highlightMonTeller10.transform.position.y+2f
		         && transform.position.y > highlightMonTeller10.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightMonTeller10.transform.position.x, highlightMonTeller10.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy (highlightMonTeller10);
			anim.SetBool("monkeyDraged", true);
			timerMonkey.timerOn();
			monkeyIsInside = true;
			transform.parent = null;
		}
		
		else 
		{
			this.drag.Play();
			//transform.position = shelfPos;
			transform.position = new Vector3(monkeyDummy.transform.position.x , monkeyDummy.transform.position.y, monkeyDummy.transform.position.z); 
			transform.localScale = new Vector3(1f, 1f, 1);
			anim.SetBool("monkeyDraged", false);
			timerMonkey.renderer.enabled = false;
			monkeyIsInside = false;
			transform.parent = camera.transform;
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
		if (highlightMonMeercat04)
		{
			highlightMonMeercat04.renderer.enabled = false;
		}
		if (highlightMonMeercat05)
		{
			highlightMonMeercat05.renderer.enabled = false;
		}
		if (highlightMonMeercat06)
		{
			highlightMonMeercat06.renderer.enabled = false;
		}		
		if (highlightMonRabbit01)
		{
			highlightMonRabbit01.renderer.enabled = false;
		}		
		if (highlightMonRabbit02)
		{
			highlightMonRabbit02.renderer.enabled = false;
		}		
		if (highlightMonRabbit03)
		{
			highlightMonRabbit03.renderer.enabled = false;
		}		
		if (highlightMonRabbit04)
		{
			highlightMonRabbit04.renderer.enabled = false;
		}
		if (highlightMonRabbit05)
		{
			highlightMonRabbit05.renderer.enabled = false;
		}			
		if (highlightMonTeller01)
		{
			highlightMonTeller01.renderer.enabled = false;
		}	
		if (highlightMonTeller02)
		{
			highlightMonTeller02.renderer.enabled = false;
		}	
		if (highlightMonTeller03)
		{
			highlightMonTeller03.renderer.enabled = false;
		}		
		if (highlightMonTeller04)
		{
			highlightMonTeller04.renderer.enabled = false;
		}
		if (highlightMonTeller05)
		{
			highlightMonTeller05.renderer.enabled = false;
		}
		if (highlightMonTeller06)
		{
			highlightMonTeller06.renderer.enabled = false;
		}
		if (highlightMonTeller07)
		{
			highlightMonTeller07.renderer.enabled = false;
		}			
		if (highlightMonTeller08)
		{
			highlightMonTeller08.renderer.enabled = false;
		}
		if (highlightMonTeller09)
		{
			highlightMonTeller09.renderer.enabled = false;
		}
		if (highlightMonTeller10)
		{
			highlightMonTeller10.renderer.enabled = false;
		}
		
	}

}
