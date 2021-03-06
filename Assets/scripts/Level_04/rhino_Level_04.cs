using UnityEngine;
using System.Collections;

public class rhino_Level_04 : MonoBehaviour
{

	//mouse and screen 
	private Vector3 screenPoint;
	private float mouseX;
	private float mouseY;
	private Vector3 mouseposition;
	
	GameObject highlightRhinoSafebox;

	GameObject highlightZebSafebox;

	private GameObject moneyTextSafebox;

	private GameObject rhinoBWDummy;

	private GameObject moneySafebox;
	
	private GameObject timerObjectRhino;
	
	public bool rhinoIsInside = false;
	
	//accessing monkey timer script
	timerRhino_Level_04 timerRhino;
		
	private GameObject dummyPos1;
	private GameObject dummyPos2;
	private GameObject dummyPos3;
	private GameObject dummyPos4;

	Vector3 shelfPos;

	Animator anim;

	GameObject rhinoDummy;

	public int dummyPosNo;
	public GameObject dummyPosition;
	
	GameObject dummyCameraZoon01;
	GameObject dummyCameraZoon02;
	
	GameObject camera;
	
	void Start ()
	{ 
		highlightRhinoSafebox = GameObject.Find ("highlightRhinoSafebox");

		dummyCameraZoon01 = GameObject.Find ("dummyCameraZoon01");
		dummyCameraZoon02 = GameObject.Find ("dummyCameraZoon02");
		camera = GameObject.Find ("Main Camera");

		//position on shelf
		dummyPos1 = GameObject.Find ("dummyPos1");
		dummyPos2 = GameObject.Find ("dummyPos2");
		dummyPos3 = GameObject.Find ("dummyPos3");
		dummyPos4 = GameObject.Find ("dummyPos4");


		highlightZebSafebox = GameObject.Find ("highlightZebSafebox");

		rhinoDummy = GameObject.Find ("rhinoDummy");
		
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
		}



		dummyPosition = GameObject.Find ("dummyPos"+dummyPosNo);


		rhinoBWDummy = GameObject.Find ("shelfPos");

		timerObjectRhino = GameObject.Find ("timerObjectRhino");

		timerRhino = GameObject.Find ("timerObjectRhino").GetComponent<timerRhino_Level_04>();



		moneyTextSafebox = GameObject.Find ("moneyTextSafebox");
	
		moneySafebox = GameObject.Find ("moneySafebox");
		
		anim = this.GetComponent<Animator>();

	}	
	
	void OnMouseOver()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

		if (highlightRhinoSafebox)
		{
			highlightRhinoSafebox.renderer.enabled = true;
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
	}


}
