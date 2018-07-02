using UnityEngine;
using System.Collections;

public class zebra_Level_04 : MonoBehaviour {
	
	//mouse and screen 
	private Vector3 screenPoint;
	private Vector3 mouseposition;
	private float mouseX;
	private float mouseY;
	
	//highlights monkey
	GameObject highlightMonMeercat01;
	GameObject highlightMonMeercat02;
	GameObject highlightMonMeercat03;
	GameObject highlightMonMeercat04;
	GameObject highlightMonRabbit01;
	GameObject highlightMonRabbit02;
	GameObject highlightMonTeller01;
	GameObject highlightMonTeller02;
	GameObject highlightMonTeller03;
	GameObject highlightMonTeller04;
	GameObject highlightMonTeller05;
	GameObject highlightMonSafebox;
	
	//highlight zebra
	GameObject highlightZebMeercat01;
	GameObject highlightZebMeercat02;
	GameObject highlightZebMeercat03;
	GameObject highlightZebMeercat04;
	GameObject highlightZebRabbit01;
	GameObject highlightZebRabbit02;
	GameObject highlightZebTeller01;
	GameObject highlightZebTeller02;
	GameObject highlightZebTeller03;
	GameObject highlightZebTeller04;
	GameObject highlightZebTeller05;
	GameObject highlightZebSafebox;
	
	private GameObject moneyTeller01;
	private GameObject moneyTeller02;
	private GameObject moneyTeller03;
	private GameObject moneyTeller04;
	private GameObject moneyTeller05;
	private GameObject moneySafebox;
	
	private GameObject timerObjectZebra;
	
	public bool zebraIsInside = false;
	
	private GameObject monkey;
	private GameObject rhino;
	
	timerMonkey_Level_04 timerMonkey;
	timerZebra_Level_04 timerZebra;
	timerRhino_Level_04 timerRhino;
	
	public AudioSource drag;
	public AudioSource moneyDone;
	
	Animator anim;
	
	private GameObject dummyPos1;
	private GameObject dummyPos2;
	private GameObject dummyPos3;
	private GameObject dummyPos4;
	
	Vector3 shelfPos;
	
	GameObject  zebraDummy;

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
		timerZebra = GameObject.Find ("timerObjectZebra").GetComponent<timerZebra_Level_04>();
		monkey = GameObject.Find ("monkey"); 
		timerMonkey = GameObject.Find ("timerObjectMonkey").GetComponent<timerMonkey_Level_04>();
		rhino = GameObject.Find ("rhino"); 
		timerRhino = GameObject.Find ("timerObjectRhino").GetComponent<timerRhino_Level_04>();
		
		highlightMonMeercat01 = GameObject.Find ("highlightMonMeercat01");
		highlightMonMeercat02 = GameObject.Find ("highlightMonMeercat02");
		highlightMonMeercat03 = GameObject.Find ("highlightMonMeercat03");
		highlightMonMeercat04 = GameObject.Find ("highlightMonMeercat04");
		highlightMonRabbit01 = GameObject.Find ("highlightMonRabbit01");
		highlightMonRabbit02 = GameObject.Find ("highlightMonRabbit02");
		highlightMonTeller01 = GameObject.Find ("highlightMonTeller01");
		highlightMonTeller02 = GameObject.Find ("highlightMonTeller02");
		highlightMonTeller03 = GameObject.Find ("highlightMonTeller03");
		highlightMonTeller04 = GameObject.Find ("highlightMonTeller04");
		highlightMonTeller05 = GameObject.Find ("highlightMonTeller05");
		highlightMonSafebox = GameObject.Find ("highlightMonSafebox");
		
		highlightZebMeercat01 = GameObject.Find ("highlightZebMeercat01");
		highlightZebMeercat02 = GameObject.Find ("highlightZebMeercat02");
		highlightZebMeercat03 = GameObject.Find ("highlightZebMeercat03");
		highlightZebMeercat04 = GameObject.Find ("highlightZebMeercat04");
		highlightZebRabbit01 = GameObject.Find ("highlightZebRabbit01");
		highlightZebRabbit02 = GameObject.Find ("highlightZebRabbit02");
		highlightZebTeller01 = GameObject.Find ("highlightZebTeller01");
		highlightZebTeller02 = GameObject.Find ("highlightZebTeller02");
		highlightZebTeller03 = GameObject.Find ("highlightZebTeller03");
		highlightZebTeller04 = GameObject.Find ("highlightZebTeller04");
		highlightZebTeller05 = GameObject.Find ("highlightZebTeller05");
		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");
		
		
		moneyTeller01 = GameObject.Find ("moneyTeller01");
		moneyTeller02 = GameObject.Find ("moneyTeller02");
		moneyTeller03 = GameObject.Find ("moneyTeller03");
		moneyTeller04 = GameObject.Find ("moneyTeller04");
		moneyTeller05 = GameObject.Find ("moneyTeller05");
		moneySafebox = GameObject.Find ("moneySafebox");
		
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
		
		if (highlightZebRabbit01 && timerMonkey.monkeyFinishedRabbit01 && transform.position != highlightZebRabbit01.transform.position && monkey.transform.position != highlightZebRabbit01.transform.position)
		{
			highlightZebRabbit01.renderer.enabled = true;
		}

		if (highlightZebRabbit02 && timerMonkey.monkeyFinishedRabbit02 && transform.position != highlightZebRabbit02.transform.position && monkey.transform.position != highlightZebRabbit02.transform.position)
		{
			highlightZebRabbit02.renderer.enabled = true;
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
		
		if (highlightZebSafebox && timerRhino.rhinoFinishedSafebox && transform.position != highlightZebSafebox.transform.position && rhino.transform.position != highlightZebSafebox.transform.position)
		{
			highlightZebSafebox.renderer.enabled = true;
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
		
		else 
		{
			this.drag.Play();
			transform.position = shelfPos;
			transform.position = new Vector3(transform.position.x + (camera.transform.position.x - dummyCameraZoon01.transform.position.x), transform.position.y, transform.position.z); 
			transform.localScale = new Vector3(-1f, 1f, 1);
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
		
		if (highlightZebRabbit01)
		{
			highlightZebRabbit01.renderer.enabled = false;
		}

		if (highlightZebRabbit02)
		{
			highlightZebRabbit02.renderer.enabled = false;
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
		
		if (highlightZebSafebox)
		{
			highlightZebSafebox.renderer.enabled = false;
		}
	}
	
}

