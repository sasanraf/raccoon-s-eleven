using UnityEngine;
using System.Collections;

public class rhino_Level_09 : MonoBehaviour
{

	//mouse and screen 
	private Vector3 screenPoint;
	private float mouseX;
	private float mouseY;
	private Vector3 mouseposition;
	
	GameObject highlightRhinoSafebox;
	GameObject highlightRhinoSafebox02;
	GameObject highlightRhinoSafebox03;

	GameObject highlightZebSafebox;
	GameObject highlightZebSafebox02;
	GameObject highlightZebSafebox03;
	
	private GameObject moneyTextSafebox;
	private GameObject moneyTextSafebox02;
	private GameObject moneyTextSafebox03;
	
	private GameObject moneySafebox;
	private GameObject moneySafebox02;
	private GameObject moneySafebox03;
	
	private GameObject timerObjectRhino;
	
	public bool rhinoIsInside = false;
	
	//accessing monkey timer script
	timerRhino_Level_09 timerRhino;
		
	private GameObject dummyPos1;
	private GameObject dummyPos2;
	private GameObject dummyPos3;
	private GameObject dummyPos4;

	Vector3 shelfPos;

	Animator anim;

	GameObject rhinoDummy;

	public int dummyPosNo;

	
	GameObject dummyCameraZoon01;
	GameObject dummyCameraZoon02;
	
	GameObject camera;
	
	void Start ()
	{ 
		highlightRhinoSafebox = GameObject.Find ("highlightRhinoSafebox");
		highlightRhinoSafebox02 = GameObject.Find ("highlightRhinoSafebox02");
		highlightRhinoSafebox03 = GameObject.Find ("highlightRhinoSafebox03");
		
		dummyCameraZoon01 = GameObject.Find ("dummyCameraZoon01");
		dummyCameraZoon02 = GameObject.Find ("dummyCameraZoon02");
		camera = GameObject.Find ("Main Camera");

		//position on shelf
		dummyPos1 = GameObject.Find ("dummyPos1");
		dummyPos2 = GameObject.Find ("dummyPos2");
		dummyPos3 = GameObject.Find ("dummyPos3");
		dummyPos4 = GameObject.Find ("dummyPos4");

		rhinoDummy = GameObject.Find ("rhinoDummy");


		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");
		highlightZebSafebox02 = GameObject.Find ("highlightZebSafebox02");
		highlightZebSafebox03 = GameObject.Find ("highlightZebSafebox03");
		
		if (PlayerPrefs.GetString("chaPos1") == "rhino")
		{
			transform.position = dummyPos1.transform.position;
			shelfPos = dummyPos1.transform.position;
			rhinoDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos2") == "rhino")
		{
			transform.position = dummyPos2.transform.position;
			shelfPos = dummyPos2.transform.position;
			rhinoDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos3") == "rhino")
		{
			transform.position = dummyPos3.transform.position;
			shelfPos = dummyPos3.transform.position;
			rhinoDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos4") == "rhino")
		{
			transform.position = dummyPos4.transform.position;
			shelfPos = dummyPos4.transform.position;
			rhinoDummy.transform.position = shelfPos;
		}

		else if (highlightZebSafebox)
		{
			Destroy(highlightZebSafebox);
			Destroy(highlightZebSafebox02);
			Destroy(highlightZebSafebox03);
		}




		timerObjectRhino = GameObject.Find ("timerObjectRhino");

		timerRhino = GameObject.Find ("timerObjectRhino").GetComponent<timerRhino_Level_09>();

		moneyTextSafebox = GameObject.Find ("moneyTextSafebox");
		moneyTextSafebox02 = GameObject.Find ("moneyTextSafebox02");
		moneyTextSafebox03 = GameObject.Find ("moneyTextSafebox03");
		
		moneySafebox = GameObject.Find ("moneySafebox");
		moneySafebox02 = GameObject.Find ("moneySafebox02");
		moneySafebox03 = GameObject.Find ("moneySafebox03");
		
		anim = this.GetComponent<Animator>();

	}	
	
	void OnMouseOver()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

		if (highlightRhinoSafebox)
		{
			highlightRhinoSafebox.renderer.enabled = true;
		}

		if (highlightRhinoSafebox02)
		{
			highlightRhinoSafebox02.renderer.enabled = true;
		}
		
		if (highlightRhinoSafebox03)
		{
			highlightRhinoSafebox03.renderer.enabled = true;
		}
		
	}
	
	void OnMouseDrag()  
	{		
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 currentPos = Camera.main.ScreenToWorldPoint (currentScreenPoint);
		transform.position = currentPos;
		
		//check if player move rhino before timer finish and destroy the zebra highlight 

		if (timerObjectRhino.renderer.enabled == true)
		{
	
			if (timerRhino.rhinoFinishedSafebox == false && highlightZebSafebox && transform.position.x < highlightZebSafebox.transform.position.x+2.5f
			         && transform.position.x > highlightZebSafebox.transform.position.x-2.5f
			         && transform.position.y < highlightZebSafebox.transform.position.y+2.5f
			         && transform.position.y > highlightZebSafebox.transform.position.y-2.5f
			         )
			{
				timerRhino.timeroff();
				Destroy (highlightZebSafebox);
			}

			if (timerRhino.rhinoFinishedSafebox02 == false && highlightZebSafebox02 && transform.position.x < highlightZebSafebox02.transform.position.x+2.5f
			         && transform.position.x > highlightZebSafebox02.transform.position.x-2.5f
			         && transform.position.y < highlightZebSafebox02.transform.position.y+2.5f
			         && transform.position.y > highlightZebSafebox02.transform.position.y-2.5f
			         )
			{
				timerRhino.timeroff();
				Destroy (highlightZebSafebox02);
			}	

			if (timerRhino.rhinoFinishedSafebox03 == false && highlightZebSafebox03 && transform.position.x < highlightZebSafebox03.transform.position.x+2.5f
			         && transform.position.x > highlightZebSafebox03.transform.position.x-2.5f
			         && transform.position.y < highlightZebSafebox03.transform.position.y+2.5f
			         && transform.position.y > highlightZebSafebox03.transform.position.y-2.5f
			         )
			{
				timerRhino.timeroff();
				Destroy (highlightZebSafebox03);
			}				
			
		}
	}
	
	void OnMouseUp () 
	{

		if (highlightRhinoSafebox && transform.position.x < highlightRhinoSafebox.transform.position.x+2.5f
		    && transform.position.x > highlightRhinoSafebox.transform.position.x-2.5f
		    && transform.position.y < highlightRhinoSafebox.transform.position.y+2.5f
		    && transform.position.y > highlightRhinoSafebox.transform.position.y-2.5f)
		{
			this.audio.Play();
			transform.position = new Vector3(highlightRhinoSafebox.transform.position.x, highlightRhinoSafebox.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightRhinoSafebox);
			anim.SetBool("rhinoDraged", true);
			timerRhino.timerOn();
			rhinoIsInside = true;
			transform.parent = null;
		}
		
		else if (highlightRhinoSafebox02 && transform.position.x < highlightRhinoSafebox02.transform.position.x+2.5f
		    && transform.position.x > highlightRhinoSafebox02.transform.position.x-2.5f
		    && transform.position.y < highlightRhinoSafebox02.transform.position.y+2.5f
		    && transform.position.y > highlightRhinoSafebox02.transform.position.y-2.5f)
		{
			this.audio.Play();
			transform.position = new Vector3(highlightRhinoSafebox02.transform.position.x, highlightRhinoSafebox02.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightRhinoSafebox02);
			anim.SetBool("rhinoDraged", true);
			timerRhino.timerOn();
			rhinoIsInside = true;
			transform.parent = null;
		}	

		else if (highlightRhinoSafebox03 && transform.position.x < highlightRhinoSafebox03.transform.position.x+2.5f
		    && transform.position.x > highlightRhinoSafebox03.transform.position.x-2.5f
		    && transform.position.y < highlightRhinoSafebox03.transform.position.y+2.5f
		    && transform.position.y > highlightRhinoSafebox03.transform.position.y-2.5f)
		{
			this.audio.Play();
			transform.position = new Vector3(highlightRhinoSafebox03.transform.position.x, highlightRhinoSafebox03.transform.position.y, 0);
			transform.localScale = new Vector3(1f, 1f, 1);
			Destroy (highlightRhinoSafebox03);
			anim.SetBool("rhinoDraged", true);
			timerRhino.timerOn();
			rhinoIsInside = true;
			transform.parent = null;
		}			
		
		else 
		{
			transform.position = shelfPos;
			transform.position = new Vector3(transform.position.x + (camera.transform.position.x - dummyCameraZoon01.transform.position.x), transform.position.y, transform.position.z); 
			transform.localScale = new Vector3(-1f, 1f, 1);
			anim.SetBool("rhinoDraged", false);
			timerRhino.renderer.enabled = false;
			rhinoIsInside = false;
			transform.parent = camera.transform;
		}

	}
	
	void OnMouseExit()
	{
		
		if (highlightRhinoSafebox)
		{
			highlightRhinoSafebox.renderer.enabled = false;
		}
		
		if (highlightRhinoSafebox02)
		{
			highlightRhinoSafebox02.renderer.enabled = false;
		}
		
		if (highlightRhinoSafebox03)
		{
			highlightRhinoSafebox03.renderer.enabled = false;
		}
	}


}
