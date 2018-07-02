using UnityEngine;
using System.Collections;

public class gorilla_Level_10 : MonoBehaviour 
{	

	//mouse and screen 
	Vector3 screenPoint;
	float mouseX;
	float mouseY;
	Vector3 mouseposition;

	public bool gorillaIsInside = false;
	public bool gorillaIsInsideZoon2 = false;

	GameObject dummyPos1;
	GameObject dummyPos2;
	GameObject dummyPos3;
	GameObject dummyPos4;
	
	GameObject gorillaDummy;

	Vector3 shelfPos;
	
	Animator anim;

	GameObject dog;
	GameObject dog2;

	dog_Level_10 dogScript;
	dog2_Level_10 dog2Script;

	GameObject highlightDog;
	GameObject highlightDog2;

	public GameObject dummyPosition;
	
	GameObject dummyCameraZoon01;
	GameObject dummyCameraZoon02;
	
	GameObject camera;

	void Start ()
	{
		dummyCameraZoon01 = GameObject.Find ("dummyCameraZoon01");
		dummyCameraZoon02 = GameObject.Find ("dummyCameraZoon02");
		camera = GameObject.Find ("Main Camera");
		
		//gorilla position on shelf
		dummyPos1 = GameObject.Find ("dummyPos1");
		dummyPos2 = GameObject.Find ("dummyPos2");
		dummyPos3 = GameObject.Find ("dummyPos3");
		dummyPos4 = GameObject.Find ("dummyPos4");
		
		gorillaDummy = GameObject.Find ("gorillaDummy");
		
		if (PlayerPrefs.GetString("chaPos1") == "gorilla")
		{
			transform.position = dummyPos1.transform.position;
			shelfPos = dummyPos1.transform.position;
			gorillaDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos2") == "gorilla")
		{
			transform.position = dummyPos2.transform.position;
			shelfPos = dummyPos2.transform.position;
			gorillaDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos3") == "gorilla")
		{
			transform.position = dummyPos3.transform.position;
			shelfPos = dummyPos3.transform.position;
			gorillaDummy.transform.position = shelfPos;
		}
		else if (PlayerPrefs.GetString("chaPos4") == "gorilla")
		{
			transform.position = dummyPos4.transform.position;
			shelfPos = dummyPos4.transform.position;
			gorillaDummy.transform.position = shelfPos;
		}

		highlightDog = GameObject.Find ("highlightDog");
		highlightDog2 = GameObject.Find ("highlightDog02");
		dog = GameObject.Find ("dog");
		dog2 = GameObject.Find ("dog2");
		dogScript = GameObject.Find("dog").GetComponent<dog_Level_10>();
		dog2Script = GameObject.Find("dog2").GetComponent<dog2_Level_10>();
		
		anim = this.GetComponent<Animator>();
	}

	void OnMouseOver() 
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

		if (dogScript.dogWalked == true || dog2Script.dogWalked == true)
		{
			highlightDog.renderer.enabled = true;
			highlightDog2.renderer.enabled = true;
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
		
		if (highlightDog.renderer.enabled == true && transform.position.x < highlightDog.transform.position.x+2f
		    && transform.position.x > highlightDog.transform.position.x-2f
		    && transform.position.y < highlightDog.transform.position.y+2f
		    && transform.position.y > highlightDog.transform.position.y-2f
		    )
		{
			audio.Play();
			transform.position = new Vector3(highlightDog.transform.position.x, highlightDog.transform.position.y, 0);
			anim.SetBool("gorillaDraged", true);
			gorillaIsInside = true;
			transform.parent = null;
			if (dog.transform.position.x > highlightDog.transform.position.x)
			{
				transform.localScale = new Vector3(-1f, 1f, 1);
			}
			else 
			{
				transform.localScale = new Vector3(1f, 1f, 1);
			}
		}	

		else if (highlightDog2.renderer.enabled == true && transform.position.x < highlightDog2.transform.position.x+2f
		    && transform.position.x > highlightDog2.transform.position.x-2f
		    && transform.position.y < highlightDog2.transform.position.y+2f
		    && transform.position.y > highlightDog2.transform.position.y-2f
		    )
		{
			audio.Play();
			transform.position = new Vector3(highlightDog2.transform.position.x, highlightDog2.transform.position.y, 0);
			anim.SetBool("gorillaDraged", true);
			gorillaIsInsideZoon2 = true;
			transform.parent = null;
			if (dog2.transform.position.x > highlightDog2.transform.position.x)
			{
				transform.localScale = new Vector3(-1f, 1f, 1);
			}
			else 
			{
				transform.localScale = new Vector3(1f, 1f, 1);
			}
		}

		else 
		{
			audio.Play();
			//transform.position = shelfPos;
			transform.position = new Vector3(gorillaDummy.transform.position.x, gorillaDummy.transform.position.y, gorillaDummy.transform.position.z); 
			transform.localScale = new Vector3(-1f, 1f, 1);
			anim.SetBool("gorillaDraged", false);
			gorillaIsInside = false;
			gorillaIsInsideZoon2 = false;
			transform.parent = camera.transform;
		}

		
	}

	void OnMouseExit()
	{
		highlightDog.renderer.enabled = false;
		highlightDog2.renderer.enabled = false;
	}

}
