using UnityEngine;
using System.Collections;

public class zebra_Level_10 : MonoBehaviour {
	
	//mouse and screen 
	Vector3 screenPoint;
	Vector3 mouseposition;
	float mouseX;
	float mouseY;
	
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
	GameObject highlightZebSafebox;
	GameObject highlightZebSafebox02;
	GameObject highlightZebSafebox03;
	
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
	
	GameObject timerObjectZebra;
	
	public bool zebraIsInside = false;
	
	GameObject monkey;
	GameObject rhino;
	
	timerMonkey_Level_10 timerMonkey;
	timerZebra_Level_10 timerZebra;
	timerRhino_Level_10 timerRhino;
	
	public AudioSource drag;
	public AudioSource moneyDone;
	
	Animator anim;
	
	GameObject dummyPos1;
	GameObject dummyPos2;
	GameObject dummyPos3;
	GameObject dummyPos4;
	
	Vector3 shelfPos;
	
	GameObject  zebraDummy;

	public int dummyPosNo;
	public GameObject dummyPosition;
	
	GameObject dummyCameraZoon01;
	GameObject dummyCameraZoon02;
	
	GameObject camera;

	GameObject moneySafebox;
	GameObject moneySafebox02;
	GameObject moneySafebox03;
	
	void Start ()
	{ 
		dummyCameraZoon01 = GameObject.Find ("dummyCameraZoon01");
		dummyCameraZoon02 = GameObject.Find ("dummyCameraZoon02");
		camera = GameObject.Find ("Main Camera");

		AudioSource[] audios = GetComponents<AudioSource>();
		drag = audios[0];
		moneyDone = audios[1];
		
		//position on shelf
		dummyPos1 = GameObject.Find ("dummyPos1");
		dummyPos2 = GameObject.Find ("dummyPos2");
		dummyPos3 = GameObject.Find ("dummyPos3");
		dummyPos4 = GameObject.Find ("dummyPos4");
		
		zebraDummy = GameObject.Find ("zebraDummy");
		
		if (PlayerPrefs.GetString("chaPos1") == "zebra")
		{
			transform.position = dummyPos1.transform.position;
			shelfPos = dummyPos1.transform.position;
			zebraDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos2") == "zebra")
		{
			transform.position = dummyPos2.transform.position;
			shelfPos = dummyPos2.transform.position;
			zebraDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos3") == "zebra")
		{
			transform.position = dummyPos3.transform.position;
			shelfPos = dummyPos3.transform.position;
			zebraDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos4") == "zebra")
		{
			transform.position = dummyPos4.transform.position;
			shelfPos = dummyPos4.transform.position;
			zebraDummy.transform.position = shelfPos;
		}
		
		dummyPosition = GameObject.Find ("dummyPos"+dummyPosNo);
		
		
		timerObjectZebra = GameObject.Find ("timerObjectZebra");
		timerZebra = GameObject.Find ("timerObjectZebra").GetComponent<timerZebra_Level_10>();
		monkey = GameObject.Find ("monkey"); 
		timerMonkey = GameObject.Find ("timerObjectMonkey").GetComponent<timerMonkey_Level_10>();
		rhino = GameObject.Find ("rhino"); 
		timerRhino = GameObject.Find ("timerObjectRhino").GetComponent<timerRhino_Level_10>();
		
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
		highlightZebSafebox  = GameObject.Find ("highlightZebSafebox");
		highlightZebSafebox02 = GameObject.Find ("highlightZebSafebox02");
		highlightZebSafebox03 = GameObject.Find ("highlightZebSafebox03");
		
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
		
		moneySafebox = GameObject.Find ("moneySafebox");
		moneySafebox02 = GameObject.Find ("moneySafebox02");
		moneySafebox03 = GameObject.Find ("moneySafebox03");
		
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
		if (highlightZebMeercat04 && timerMonkey.monkeyFinishedMeercat04 && transform.position != highlightZebMeercat04.transform.position && monkey.transform.position != highlightZebMeercat04.transform.position)
		{
			highlightZebMeercat04.renderer.enabled = true;
		}
		if (highlightZebMeercat05 && timerMonkey.monkeyFinishedMeercat05 && transform.position != highlightZebMeercat05.transform.position && monkey.transform.position != highlightZebMeercat05.transform.position)
		{
			highlightZebMeercat05.renderer.enabled = true;
		}		
		if (highlightZebMeercat06 && timerMonkey.monkeyFinishedMeercat06 && transform.position != highlightZebMeercat06.transform.position && monkey.transform.position != highlightZebMeercat06.transform.position)
		{
			highlightZebMeercat06.renderer.enabled = true;
		}
		
		if (highlightZebRabbit01 && timerMonkey.monkeyFinishedRabbit01 && transform.position != highlightZebRabbit01.transform.position && monkey.transform.position != highlightZebRabbit01.transform.position)
		{
			highlightZebRabbit01.renderer.enabled = true;
		}

		if (highlightZebRabbit02 && timerMonkey.monkeyFinishedRabbit02 && transform.position != highlightZebRabbit02.transform.position && monkey.transform.position != highlightZebRabbit02.transform.position)
		{
			highlightZebRabbit02.renderer.enabled = true;
		}
		
		if (highlightZebRabbit03 && timerMonkey.monkeyFinishedRabbit03 && transform.position != highlightZebRabbit03.transform.position && monkey.transform.position != highlightZebRabbit03.transform.position)
		{
			highlightZebRabbit03.renderer.enabled = true;
		}
		
		if (highlightZebRabbit04 && timerMonkey.monkeyFinishedRabbit04 && transform.position != highlightZebRabbit04.transform.position && monkey.transform.position != highlightZebRabbit04.transform.position)
		{
			highlightZebRabbit04.renderer.enabled = true;
		}
		
		if (highlightZebRabbit05 && timerMonkey.monkeyFinishedRabbit05 && transform.position != highlightZebRabbit05.transform.position && monkey.transform.position != highlightZebRabbit05.transform.position)
		{
			highlightZebRabbit05.renderer.enabled = true;
		}
		
		if (highlightZebTeller01 && timerMonkey.monkeyFinishedTeller01 && transform.position != highlightZebTeller01.transform.position && monkey.transform.position != highlightZebTeller01.transform.position)
		{
			highlightZebTeller01.renderer.enabled = true;
		}
		
		if (highlightZebTeller02 && timerMonkey.monkeyFinishedTeller02 && transform.position != highlightZebTeller02.transform.position && monkey.transform.position != highlightZebTeller02.transform.position)
		{
			highlightZebTeller02.renderer.enabled = true;
		}
		
		if (highlightZebTeller03 && timerMonkey.monkeyFinishedTeller03 && transform.position != highlightZebTeller03.transform.position && monkey.transform.position != highlightZebTeller03.transform.position)
		{
			highlightZebTeller03.renderer.enabled = true;
		}

		if (highlightZebTeller04 && timerMonkey.monkeyFinishedTeller04 && transform.position != highlightZebTeller04.transform.position && monkey.transform.position != highlightZebTeller04.transform.position)
		{
			highlightZebTeller04.renderer.enabled = true;
		}	
		if (highlightZebTeller05 && timerMonkey.monkeyFinishedTeller05 && transform.position != highlightZebTeller05.transform.position && monkey.transform.position != highlightZebTeller05.transform.position)
		{
			highlightZebTeller05.renderer.enabled = true;
		}
		if (highlightZebTeller06 && timerMonkey.monkeyFinishedTeller06 && transform.position != highlightZebTeller06.transform.position && monkey.transform.position != highlightZebTeller06.transform.position)
		{
			highlightZebTeller06.renderer.enabled = true;
		}
		if (highlightZebTeller07 && timerMonkey.monkeyFinishedTeller07 && transform.position != highlightZebTeller07.transform.position && monkey.transform.position != highlightZebTeller07.transform.position)
		{
			highlightZebTeller07.renderer.enabled = true;
		}
		
		if (highlightZebTeller08 && timerMonkey.monkeyFinishedTeller08 && transform.position != highlightZebTeller08.transform.position && monkey.transform.position != highlightZebTeller08.transform.position)
		{
			highlightZebTeller08.renderer.enabled = true;
		}
		
		if (highlightZebTeller09 && timerMonkey.monkeyFinishedTeller09 && transform.position != highlightZebTeller09.transform.position && monkey.transform.position != highlightZebTeller09.transform.position)
		{
			highlightZebTeller09.renderer.enabled = true;
		}
		
		if (highlightZebTeller10 && timerMonkey.monkeyFinishedTeller10 && transform.position != highlightZebTeller10.transform.position && monkey.transform.position != highlightZebTeller10.transform.position)
		{
			highlightZebTeller10.renderer.enabled = true;
		}
		
		if (highlightZebSafebox && timerRhino.rhinoFinishedSafebox && transform.position != highlightZebSafebox.transform.position && rhino.transform.position != highlightZebSafebox.transform.position)
		{
			highlightZebSafebox.renderer.enabled = true;
		}
		
		if (highlightZebSafebox02 && timerRhino.rhinoFinishedSafebox02 && transform.position != highlightZebSafebox02.transform.position && rhino.transform.position != highlightZebSafebox02.transform.position)
		{
			highlightZebSafebox02.renderer.enabled = true;
		}		
		
		if (highlightZebSafebox03 && timerRhino.rhinoFinishedSafebox03 && transform.position != highlightZebSafebox03.transform.position && rhino.transform.position != highlightZebSafebox03.transform.position)
		{
			highlightZebSafebox03.renderer.enabled = true;
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
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebMeercat01);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebMeercat02 && timerMonkey.monkeyFinishedMeercat02 && monkey.transform.position != highlightZebMeercat02.transform.position && transform.position.x < highlightZebMeercat02.transform.position.x+2f
		    && transform.position.x > highlightZebMeercat02.transform.position.x-2f
		    && transform.position.y < highlightZebMeercat02.transform.position.y+2f
		    && transform.position.y > highlightZebMeercat02.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebMeercat02.transform.position.x, highlightZebMeercat02.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebMeercat02);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebMeercat03 && timerMonkey.monkeyFinishedMeercat03 && monkey.transform.position != highlightZebMeercat03.transform.position && transform.position.x < highlightZebMeercat03.transform.position.x+2f
		    && transform.position.x > highlightZebMeercat03.transform.position.x-2f
		    && transform.position.y < highlightZebMeercat03.transform.position.y+2f
		    && transform.position.y > highlightZebMeercat03.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebMeercat03.transform.position.x, highlightZebMeercat03.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebMeercat03);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebMeercat04 && timerMonkey.monkeyFinishedMeercat04 && monkey.transform.position != highlightZebMeercat04.transform.position && transform.position.x < highlightZebMeercat04.transform.position.x+2f
		    && transform.position.x > highlightZebMeercat04.transform.position.x-2f
		    && transform.position.y < highlightZebMeercat04.transform.position.y+2f
		    && transform.position.y > highlightZebMeercat04.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebMeercat04.transform.position.x, highlightZebMeercat04.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebMeercat04);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebMeercat05 && timerMonkey.monkeyFinishedMeercat05 && monkey.transform.position != highlightZebMeercat05.transform.position && transform.position.x < highlightZebMeercat05.transform.position.x+2f
		    && transform.position.x > highlightZebMeercat05.transform.position.x-2f
		    && transform.position.y < highlightZebMeercat05.transform.position.y+2f
		    && transform.position.y > highlightZebMeercat05.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebMeercat05.transform.position.x, highlightZebMeercat05.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebMeercat05);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebMeercat06 && timerMonkey.monkeyFinishedMeercat06 && monkey.transform.position != highlightZebMeercat06.transform.position && transform.position.x < highlightZebMeercat06.transform.position.x+2f
		    && transform.position.x > highlightZebMeercat06.transform.position.x-2f
		    && transform.position.y < highlightZebMeercat06.transform.position.y+2f
		    && transform.position.y > highlightZebMeercat06.transform.position.y-2f
		    )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebMeercat06.transform.position.x, highlightZebMeercat06.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebMeercat06);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebRabbit01 && timerMonkey.monkeyFinishedRabbit01 && monkey.transform.position != highlightZebRabbit01.transform.position && transform.position.x < highlightZebRabbit01.transform.position.x+2f
		         && transform.position.x > highlightZebRabbit01.transform.position.x-2f
		         && transform.position.y < highlightZebRabbit01.transform.position.y+2f
		         && transform.position.y > highlightZebRabbit01.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebRabbit01.transform.position.x, highlightZebRabbit01.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebRabbit01);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}

		else if (highlightZebRabbit02 && timerMonkey.monkeyFinishedRabbit02 && monkey.transform.position != highlightZebRabbit02.transform.position && transform.position.x < highlightZebRabbit02.transform.position.x+2f
		         && transform.position.x > highlightZebRabbit02.transform.position.x-2f
		         && transform.position.y < highlightZebRabbit02.transform.position.y+2f
		         && transform.position.y > highlightZebRabbit02.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebRabbit02.transform.position.x, highlightZebRabbit02.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebRabbit02);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebRabbit03 && timerMonkey.monkeyFinishedRabbit03 && monkey.transform.position != highlightZebRabbit03.transform.position && transform.position.x < highlightZebRabbit03.transform.position.x+2f
		         && transform.position.x > highlightZebRabbit03.transform.position.x-2f
		         && transform.position.y < highlightZebRabbit03.transform.position.y+2f
		         && transform.position.y > highlightZebRabbit03.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebRabbit03.transform.position.x, highlightZebRabbit03.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebRabbit03);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebRabbit04 && timerMonkey.monkeyFinishedRabbit04 && monkey.transform.position != highlightZebRabbit04.transform.position && transform.position.x < highlightZebRabbit04.transform.position.x+2f
		         && transform.position.x > highlightZebRabbit04.transform.position.x-2f
		         && transform.position.y < highlightZebRabbit04.transform.position.y+2f
		         && transform.position.y > highlightZebRabbit04.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebRabbit04.transform.position.x, highlightZebRabbit04.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebRabbit04);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebRabbit05 && timerMonkey.monkeyFinishedRabbit05 && monkey.transform.position != highlightZebRabbit05.transform.position && transform.position.x < highlightZebRabbit04.transform.position.x+2f
		         && transform.position.x > highlightZebRabbit05.transform.position.x-2f
		         && transform.position.y < highlightZebRabbit05.transform.position.y+2f
		         && transform.position.y > highlightZebRabbit05.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebRabbit05.transform.position.x, highlightZebRabbit05.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebRabbit05);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
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
			transform.parent = null;
		}
		
		else if (highlightZebTeller02 && timerMonkey.monkeyFinishedTeller02 && monkey.transform.position != highlightZebTeller02.transform.position && transform.position.x < highlightZebTeller02.transform.position.x+2f
		         && transform.position.x > highlightZebTeller02.transform.position.x-2f
		         && transform.position.y < highlightZebTeller02.transform.position.y+2f
		         && transform.position.y > highlightZebTeller02.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller02.transform.position.x, highlightZebTeller02.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebTeller02);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
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
			transform.parent = null;
		}

		else if (highlightZebTeller04 && timerMonkey.monkeyFinishedTeller04 && monkey.transform.position != highlightZebTeller04.transform.position && transform.position.x < highlightZebTeller04.transform.position.x+2f
		         && transform.position.x > highlightZebTeller04.transform.position.x-2f
		         && transform.position.y < highlightZebTeller04.transform.position.y+2f
		         && transform.position.y > highlightZebTeller04.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller04.transform.position.x, highlightZebTeller04.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebTeller04);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}

		else if (highlightZebTeller05 && timerMonkey.monkeyFinishedTeller05 && monkey.transform.position != highlightZebTeller05.transform.position && transform.position.x < highlightZebTeller05.transform.position.x+2f
		         && transform.position.x > highlightZebTeller05.transform.position.x-2f
		         && transform.position.y < highlightZebTeller05.transform.position.y+2f
		         && transform.position.y > highlightZebTeller05.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller05.transform.position.x, highlightZebTeller05.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebTeller05);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
	
		else if (highlightZebTeller06 && timerMonkey.monkeyFinishedTeller06 && monkey.transform.position != highlightZebTeller06.transform.position && transform.position.x < highlightZebTeller06.transform.position.x+2f
		         && transform.position.x > highlightZebTeller06.transform.position.x-2f
		         && transform.position.y < highlightZebTeller06.transform.position.y+2f
		         && transform.position.y > highlightZebTeller06.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller06.transform.position.x, highlightZebTeller06.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebTeller06);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebTeller07 && timerMonkey.monkeyFinishedTeller07 && monkey.transform.position != highlightZebTeller07.transform.position && transform.position.x < highlightZebTeller07.transform.position.x+2f
		         && transform.position.x > highlightZebTeller07.transform.position.x-2f
		         && transform.position.y < highlightZebTeller07.transform.position.y+2f
		         && transform.position.y > highlightZebTeller07.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller07.transform.position.x, highlightZebTeller07.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebTeller07);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebTeller08 && timerMonkey.monkeyFinishedTeller08 && monkey.transform.position != highlightZebTeller08.transform.position && transform.position.x < highlightZebTeller08.transform.position.x+2f
		         && transform.position.x > highlightZebTeller08.transform.position.x-2f
		         && transform.position.y < highlightZebTeller08.transform.position.y+2f
		         && transform.position.y > highlightZebTeller08.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller08.transform.position.x, highlightZebTeller08.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebTeller08);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebTeller09 && timerMonkey.monkeyFinishedTeller09 && monkey.transform.position != highlightZebTeller09.transform.position && transform.position.x < highlightZebTeller09.transform.position.x+2f
		         && transform.position.x > highlightZebTeller09.transform.position.x-2f
		         && transform.position.y < highlightZebTeller09.transform.position.y+2f
		         && transform.position.y > highlightZebTeller09.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller09.transform.position.x, highlightZebTeller09.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebTeller09);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebTeller10 && timerMonkey.monkeyFinishedTeller10 && monkey.transform.position != highlightZebTeller10.transform.position && transform.position.x < highlightZebTeller10.transform.position.x+2f
		         && transform.position.x > highlightZebTeller10.transform.position.x-2f
		         && transform.position.y < highlightZebTeller10.transform.position.y+2f
		         && transform.position.y > highlightZebTeller10.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebTeller10.transform.position.x, highlightZebTeller10.transform.position.y, 0);
			transform.localScale = new Vector3(-1f, 1f, 1);
			Destroy(highlightZebTeller10);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebSafebox && timerRhino.rhinoFinishedSafebox && rhino.transform.position != highlightZebSafebox.transform.position && transform.position.x < highlightZebSafebox.transform.position.x+2f
		         && transform.position.x > highlightZebSafebox.transform.position.x-2f
		         && transform.position.y < highlightZebSafebox.transform.position.y+2f
		         && transform.position.y > highlightZebSafebox.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebSafebox.transform.position.x, highlightZebSafebox.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebSafebox);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightZebSafebox02 && timerRhino.rhinoFinishedSafebox02 && rhino.transform.position != highlightZebSafebox02.transform.position && transform.position.x < highlightZebSafebox02.transform.position.x+2f
		         && transform.position.x > highlightZebSafebox02.transform.position.x-2f
		         && transform.position.y < highlightZebSafebox02.transform.position.y+2f
		         && transform.position.y > highlightZebSafebox02.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebSafebox02.transform.position.x, highlightZebSafebox02.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebSafebox02);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}	

		else if (highlightZebSafebox03 && timerRhino.rhinoFinishedSafebox03 && rhino.transform.position != highlightZebSafebox03.transform.position && transform.position.x < highlightZebSafebox03.transform.position.x+2f
		         && transform.position.x > highlightZebSafebox03.transform.position.x-2f
		         && transform.position.y < highlightZebSafebox03.transform.position.y+2f
		         && transform.position.y > highlightZebSafebox03.transform.position.y-2f
		         )
		{
			this.drag.Play();
			transform.position = new Vector3(highlightZebSafebox03.transform.position.x, highlightZebSafebox03.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy(highlightZebSafebox03);
			anim.SetBool("zebraDraged", true);
			timerZebra.timerOn();
			zebraIsInside = true;
			transform.parent = null;
		}			
		
		else 
		{
			this.drag.Play();
			//transform.position = shelfPos;
			transform.position = new Vector3(zebraDummy.transform.position.x, zebraDummy.transform.position.y, zebraDummy.transform.position.z); 
			transform.localScale = new Vector3(1f, 1f, 1);
			anim.SetBool("zebraDraged", false);
			timerZebra.renderer.enabled = false;
			timerZebra.timerOff();
			zebraIsInside = false;
			transform.parent = camera.transform;
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
		if (highlightZebMeercat04)
		{
			highlightZebMeercat04.renderer.enabled = false;
		}
		if (highlightZebMeercat05)
		{
			highlightZebMeercat05.renderer.enabled = false;
		}
		if (highlightZebMeercat06)
		{
			highlightZebMeercat06.renderer.enabled = false;
		}
		
		if (highlightZebRabbit01)
		{
			highlightZebRabbit01.renderer.enabled = false;
		}		
		if (highlightZebRabbit02)
		{
			highlightZebRabbit02.renderer.enabled = false;
		}		
		if (highlightZebRabbit03)
		{
			highlightZebRabbit03.renderer.enabled = false;
		}		
		if (highlightZebRabbit04)
		{
			highlightZebRabbit04.renderer.enabled = false;
		}
		if (highlightZebRabbit05)
		{
			highlightZebRabbit05.renderer.enabled = false;
		}			
		if (highlightZebTeller01)
		{
			highlightZebTeller01.renderer.enabled = false;
		}	
		if (highlightZebTeller02)
		{
			highlightZebTeller02.renderer.enabled = false;
		}	
		if (highlightZebTeller03)
		{
			highlightZebTeller03.renderer.enabled = false;
		}		
		if (highlightZebTeller04)
		{
			highlightZebTeller04.renderer.enabled = false;
		}
		if (highlightZebTeller05)
		{
			highlightZebTeller05.renderer.enabled = false;
		}
		if (highlightZebTeller06)
		{
			highlightZebTeller06.renderer.enabled = false;
		}
		if (highlightZebTeller07)
		{
			highlightZebTeller07.renderer.enabled = false;
		}			
		if (highlightZebTeller08)
		{
			highlightZebTeller08.renderer.enabled = false;
		}
		if (highlightZebTeller09)
		{
			highlightZebTeller09.renderer.enabled = false;
		}
		if (highlightZebTeller10)
		{
			highlightZebTeller10.renderer.enabled = false;
		}
		
		if (highlightZebSafebox)
		{
			highlightZebSafebox.renderer.enabled = false;
		}
		
		if (highlightZebSafebox02)
		{
			highlightZebSafebox02.renderer.enabled = false;
		}
		
		if (highlightZebSafebox03)
		{
			highlightZebSafebox03.renderer.enabled = false;
		}
	}
	
}

